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
		[Cpp2IlInjected.Address(RVA = "0x6FBDF60", Offset = "0x6FBCF60", VA = "0x186FBDF60", Slot = "4")]
		public override void PIKNDMFIIPK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x88F9F0", Offset = "0x88E9F0", VA = "0x18088F9F0")]
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
			[Cpp2IlInjected.Address(RVA = "0x869520", Offset = "0x868520", VA = "0x180869520", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x14F9A20", Offset = "0x14F8A20", VA = "0x1814F9A20", Slot = "5")]
		public override void GFCMAGCMMPB(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6FCA0A0", Offset = "0x6FC90A0", VA = "0x186FCA0A0")]
		private void CIONGDPCBDA(DMJKCLJBHON registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6FCA3B0", Offset = "0x6FC93B0", VA = "0x186FCA3B0", Slot = "6")]
		public override void CKJFBMFKCLI(DMJKCLJBHON registry, [In] MIOEIJGFFCO filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x866350", Offset = "0x865350", VA = "0x180866350", Slot = "8")]
		public override void LOCAGFNGOIC(ADLFNLPBEEE registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6FCA410", Offset = "0x6FC9410", VA = "0x186FCA410")]
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
			[Cpp2IlInjected.Address(RVA = "0x6FC56E0", Offset = "0x6FC46E0", VA = "0x186FC56E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private APLBGFGJNCA PPPAFAIGEDM
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x8687D0", Offset = "0x8677D0", VA = "0x1808687D0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public int OBEGLHIDBFJ
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x6FC74D0", Offset = "0x6FC64D0", VA = "0x186FC74D0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public RigidbodyEx NGHIDINCOLE
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x6FC7830", Offset = "0x6FC6830", VA = "0x186FC7830")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public RigidbodyEx JJGALJKCIFK
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x6FC7770", Offset = "0x6FC6770", VA = "0x186FC7770")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public RigidbodyEx HHMPHBNGMGF
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x6FC84E0", Offset = "0x6FC74E0", VA = "0x186FC84E0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x6FC9A10", Offset = "0x6FC8A10", VA = "0x186FC9A10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public Transform OLKGLLBJDEB
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x88EDF0", Offset = "0x88DDF0", VA = "0x18088EDF0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public Transform HPKOOIKHDEI
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x88EDF0", Offset = "0x88DDF0", VA = "0x18088EDF0", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public AHOPCOINALC MOCDPHINOGF
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x6FC7530", Offset = "0x6FC6530", VA = "0x186FC7530")]
			get
			{
				return default(AHOPCOINALC);
			}
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x6FC91C0", Offset = "0x6FC81C0", VA = "0x186FC91C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool LNOIEOBPGOA
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x6FC7B40", Offset = "0x6FC6B40", VA = "0x186FC7B40")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool HLOCEFHJFJC
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x6FC7650", Offset = "0x6FC6650", VA = "0x186FC7650")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public NBGFPCGNHAJ MDIDEKBEBLF
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x6FC7A80", Offset = "0x6FC6A80", VA = "0x186FC7A80")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x6FC9380", Offset = "0x6FC8380", VA = "0x186FC9380")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public GDLMMBKDOFD PDHMDHCJJAN
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x6FC7A20", Offset = "0x6FC6A20", VA = "0x186FC7A20")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x6FC9310", Offset = "0x6FC8310", VA = "0x186FC9310")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public bool HMPBHMHCEBL
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x6FC7970", Offset = "0x6FC6970", VA = "0x186FC7970")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public Rigidbody IIPBAHLFLID
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x6FC79D0", Offset = "0x6FC69D0", VA = "0x186FC79D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool NJHCAMDGLGE
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x6FC76B0", Offset = "0x6FC66B0", VA = "0x186FC76B0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x6FC9230", Offset = "0x6FC8230", VA = "0x186FC9230")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool HNHKKNPDDHM
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x6CA14C0", Offset = "0x6CA04C0", VA = "0x186CA14C0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public float EBIBGLELPLK
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x6FC8480", Offset = "0x6FC7480", VA = "0x186FC8480")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public float EKONFELAOEI
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x6FC8420", Offset = "0x6FC7420", VA = "0x186FC8420")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x6FC99A0", Offset = "0x6FC89A0", VA = "0x186FC99A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public float EKDGABLHIEO
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x6FC7DA0", Offset = "0x6FC6DA0", VA = "0x186FC7DA0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x6FC9620", Offset = "0x6FC8620", VA = "0x186FC9620")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public float KCBCOJGBNPD
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x6FC7BA0", Offset = "0x6FC6BA0", VA = "0x186FC7BA0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x6FC93F0", Offset = "0x6FC83F0", VA = "0x186FC93F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public bool NLGHMADHINI
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x6FC8A60", Offset = "0x6FC7A60", VA = "0x186FC8A60")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x6FC9F50", Offset = "0x6FC8F50", VA = "0x186FC9F50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public Vector3 JNPBMMPAEKG
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x6FC8200", Offset = "0x6FC7200", VA = "0x186FC8200")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x6FC9770", Offset = "0x6FC8770", VA = "0x186FC9770")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public Vector3 EAFKAPPODGL
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x6FC8BA0", Offset = "0x6FC7BA0", VA = "0x186FC8BA0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public CollisionDetectionMode PJOLJLIIGEN
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x6FC7CE0", Offset = "0x6FC6CE0", VA = "0x186FC7CE0")]
			get
			{
				return default(CollisionDetectionMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x6FC9540", Offset = "0x6FC8540", VA = "0x186FC9540")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public float KHBCBMICPIE
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x6FC7710", Offset = "0x6FC6710", VA = "0x186FC7710")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x6FC92A0", Offset = "0x6FC82A0", VA = "0x186FC92A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public RigidbodyConstraints HBAOCIHDKOO
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x6FC7D40", Offset = "0x6FC6D40", VA = "0x186FC7D40")]
			get
			{
				return default(RigidbodyConstraints);
			}
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x6FC95B0", Offset = "0x6FC85B0", VA = "0x186FC95B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public Vector3 FNOIONOPHKP
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x6FC85A0", Offset = "0x6FC75A0", VA = "0x186FC85A0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public Vector3 AIDMCMNAPCM
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x6FC85A0", Offset = "0x6FC75A0", VA = "0x186FC85A0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x6FC9D30", Offset = "0x6FC8D30", VA = "0x186FC9D30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public float MMHPMHNOCBE
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x6FC82E0", Offset = "0x6FC72E0", VA = "0x186FC82E0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x6FC9850", Offset = "0x6FC8850", VA = "0x186FC9850")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public float PPHEFDMHCNP
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x6FC8A00", Offset = "0x6FC7A00", VA = "0x186FC8A00")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x6FC9EE0", Offset = "0x6FC8EE0", VA = "0x186FC9EE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public Quaternion JOLFGKGNNCC
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x6FC8680", Offset = "0x6FC7680", VA = "0x186FC8680")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x6FC9AB0", Offset = "0x6FC8AB0", VA = "0x186FC9AB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public Quaternion KGNMJDNIGAC
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x6FC8920", Offset = "0x6FC7920", VA = "0x186FC8920")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x6FC9E10", Offset = "0x6FC8E10", VA = "0x186FC9E10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public Vector3 MNHCHKLAEEO
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x6FC8760", Offset = "0x6FC7760", VA = "0x186FC8760")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x6FC9B80", Offset = "0x6FC8B80", VA = "0x186FC9B80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public Quaternion DCFEGAMOEON
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x6FC8840", Offset = "0x6FC7840", VA = "0x186FC8840")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x6FC9C60", Offset = "0x6FC8C60", VA = "0x186FC9C60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public Vector3 EFBILKIFBJD
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x6FC8AC0", Offset = "0x6FC7AC0", VA = "0x186FC8AC0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x6FC9FC0", Offset = "0x6FC8FC0", VA = "0x186FC9FC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public Vector3 JPHCCCIGOIO
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x6FC8340", Offset = "0x6FC7340", VA = "0x186FC8340")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x6FC98C0", Offset = "0x6FC88C0", VA = "0x186FC98C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public Vector3 BEELOOCNBOF
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x6FC7C00", Offset = "0x6FC6C00", VA = "0x186FC7C00")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x6FC9460", Offset = "0x6FC8460", VA = "0x186FC9460")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public Vector3 ABBPNJFJIFG
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x6FC8120", Offset = "0x6FC7120", VA = "0x186FC8120")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x6FC9690", Offset = "0x6FC8690", VA = "0x186FC9690")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Vector3 EHAKGOGHFPP
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x6FC7FE0", Offset = "0x6FC6FE0", VA = "0x186FC7FE0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public Quaternion MALDBKLIIFF
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x6FC7F00", Offset = "0x6FC6F00", VA = "0x186FC7F00")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public Vector3 FADALCGGBHP
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x6FC8D60", Offset = "0x6FC7D60", VA = "0x186FC8D60")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public Vector3 HOFHPDKDLEM
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x6FC8C80", Offset = "0x6FC7C80", VA = "0x186FC8C80")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public bool PANMEHIHIBN
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x6FC80C0", Offset = "0x6FC70C0", VA = "0x186FC80C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public bool AFHIINLOJFJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x6FC7AE0", Offset = "0x6FC6AE0", VA = "0x186FC7AE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool OFLEHEDDMGL
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x6FC75F0", Offset = "0x6FC65F0", VA = "0x186FC75F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool AFEJNPNMCAI
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x6FC7590", Offset = "0x6FC6590", VA = "0x186FC7590")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public bool DFJDMNDBIML
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x6FC7470", Offset = "0x6FC6470", VA = "0x186FC7470")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public bool ACFFJECCDHH
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x6FC7E00", Offset = "0x6FC6E00", VA = "0x186FC7E00")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public bool LMMCDOJHLCP
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x59E2CD0", Offset = "0x59E1CD0", VA = "0x1859E2CD0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event JHDGOPNJJCO CBDGDFADEIH
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x6FC7390", Offset = "0x6FC6390", VA = "0x186FC7390")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x6FC90E0", Offset = "0x6FC80E0", VA = "0x186FC90E0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event HJNBIKAPNHI MEJFDLJMBHA
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x6FC7100", Offset = "0x6FC6100", VA = "0x186FC7100")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x6FC8E40", Offset = "0x6FC7E40", VA = "0x186FC8E40")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event HJNBIKAPNHI CCIOFDBKGEJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x6FC7160", Offset = "0x6FC6160", VA = "0x186FC7160")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x6FC8EB0", Offset = "0x6FC7EB0", VA = "0x186FC8EB0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event HJNBIKAPNHI CGOADBPPEDL
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x6FC72B0", Offset = "0x6FC62B0", VA = "0x186FC72B0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x6FC9000", Offset = "0x6FC8000", VA = "0x186FC9000")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action<HPJFBALBIOJ, HPJFBALBIOJ> FPKHALMDLDG
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x6FC7240", Offset = "0x6FC6240", VA = "0x186FC7240")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x6FC8F90", Offset = "0x6FC7F90", VA = "0x186FC8F90")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event HJNBIKAPNHI CMIJJPBNMKC
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x6FC7320", Offset = "0x6FC6320", VA = "0x186FC7320")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x6FC9070", Offset = "0x6FC8070", VA = "0x186FC9070")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event HJNBIKAPNHI JACHILDJDFO
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x6FC7400", Offset = "0x6FC6400", VA = "0x186FC7400")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x6FC9150", Offset = "0x6FC8150", VA = "0x186FC9150")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event HJNBIKAPNHI EFMEMIAAGBB
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x6FC71D0", Offset = "0x6FC61D0", VA = "0x186FC71D0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x6FC8F20", Offset = "0x6FC7F20", VA = "0x186FC8F20")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x867E00", Offset = "0x866E00", VA = "0x180867E00", Slot = "8")]
		private void IHHELCMEMFA(APLBGFGJNCA LIGKCFOOPNO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6FC6060", Offset = "0x6FC5060", VA = "0x186FC6060")]
		internal void JGDEBKGKMBA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6FC6E20", Offset = "0x6FC5E20", VA = "0x186FC6E20")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		public void TestOverrideUnityRigidbody(Rigidbody EDIKCMCJLAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6FC5970", Offset = "0x6FC4970", VA = "0x186FC5970")]
		public GMBPJONDGEK GetChild(int LLPJHIPCNFD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x6FC6AF0", Offset = "0x6FC5AF0", VA = "0x186FC6AF0")]
		public void SetInertiaTensor((Quaternion rot, Vector3 moments) GIALOAJHHIE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6FC5670", Offset = "0x6FC4670", VA = "0x186FC5670")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x6FC56E0", Offset = "0x6FC46E0", VA = "0x186FC56E0")]
		private APLBGFGJNCA COELCLPACBC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x6FC5C20", Offset = "0x6FC4C20", VA = "0x186FC5C20")]
		private void IPJLDPAJHCH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x6FC62C0", Offset = "0x6FC52C0", VA = "0x186FC62C0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x6FC6060", Offset = "0x6FC5060", VA = "0x186FC6060")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x6FC6260", Offset = "0x6FC5260", VA = "0x186FC6260")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x6FC6320", Offset = "0x6FC5320", VA = "0x186FC6320")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x6FC4D20", Offset = "0x6FC3D20", VA = "0x186FC4D20")]
		public void AddDoNotResetVelocityOnOwnershipChangeOverride(object OEDJKICDDGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x6FC6380", Offset = "0x6FC5380", VA = "0x186FC6380")]
		public void RemoveDoNotResetVelocityOnOwnershipChangeOverride(object OEDJKICDDGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x6FC5910", Offset = "0x6FC4910", VA = "0x186FC5910")]
		public void DisableCachedInertialPropertyOverride()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x6FC6200", Offset = "0x6FC5200", VA = "0x186FC6200")]
		public void MarkCachedInertialParametersDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x6FC6C50", Offset = "0x6FC5C50", VA = "0x186FC6C50")]
		public void SetParent(RigidbodyEx CBAEIEAPLIH, bool FFPHPJEJBKL = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x6FC6690", Offset = "0x6FC5690", VA = "0x186FC6690")]
		public void ResetLocalCenterOfMassToPrefabDefault()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x6FC5E40", Offset = "0x6FC4E40", VA = "0x186FC5E40")]
		public bool IsRigidbodyAncestor(RigidbodyEx GNFLHKHMMIL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x6FC5F20", Offset = "0x6FC4F20", VA = "0x186FC5F20")]
		public bool IsRigidbodyDescendant(RigidbodyEx NAPOIPGFDKM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x6FC4F90", Offset = "0x6FC3F90", VA = "0x186FC4F90")]
		public void AddInterpolationRestriction(object OEDJKICDDGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x6FC63F0", Offset = "0x6FC53F0", VA = "0x186FC63F0")]
		public void RemoveInterpolationRestriction(object OEDJKICDDGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x6FC5000", Offset = "0x6FC4000", VA = "0x186FC5000")]
		public void AddKinematic(object OEDJKICDDGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x6FC6460", Offset = "0x6FC5460", VA = "0x186FC6460")]
		public void RemoveKinematic(object OEDJKICDDGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x6FC6BD0", Offset = "0x6FC5BD0", VA = "0x186FC6BD0")]
		public void SetKinematic(object OEDJKICDDGA, bool OKDLNAIMGHJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x6FC69F0", Offset = "0x6FC59F0", VA = "0x186FC69F0")]
		public void SetDiscontinuousPositionAndRotation(Vector3 JLPKCGDHNKG, Quaternion GDJCCIDIKIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x6FC68F0", Offset = "0x6FC58F0", VA = "0x186FC68F0")]
		public void SetDiscontinuousLocalPositionAndLocalRotation(Vector3 KFJLMDEKNOI, Quaternion NPNKNILIGCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x6FC5B10", Offset = "0x6FC4B10", VA = "0x186FC5B10")]
		public Vector3 GetConstrainedVelocity(Vector3 EFBILKIFBJD)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x6FC5A00", Offset = "0x6FC4A00", VA = "0x186FC5A00")]
		public Vector3 GetConstrainedAngularVelocity(Vector3 BEELOOCNBOF)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x6FC4EA0", Offset = "0x6FC3EA0", VA = "0x186FC4EA0")]
		public void AddForce(Vector3 BAKDLGCFEEB, ForceMode CGHFFMJLLOB = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x6FC4D90", Offset = "0x6FC3D90", VA = "0x186FC4D90")]
		public void AddForceAtPosition(Vector3 BAKDLGCFEEB, Vector3 MOIICCIPACK, ForceMode CGHFFMJLLOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x6FC51D0", Offset = "0x6FC41D0", VA = "0x186FC51D0")]
		public void AddTorque(Vector3 OAEKPIGFLHH, ForceMode CGHFFMJLLOB = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x6FC5070", Offset = "0x6FC4070", VA = "0x186FC5070")]
		public void AddRelativeTorque(Vector3 OAEKPIGFLHH, ForceMode CGHFFMJLLOB = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x6FC6EF0", Offset = "0x6FC5EF0", VA = "0x186FC6EF0")]
		public Vector3 WorldToLocalVelocity(Vector3 GAIBCOAKDKC)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x6FC60F0", Offset = "0x6FC50F0", VA = "0x186FC60F0")]
		public Vector3 LocalToWorldVelocity(Vector3 JPHCCCIGOIO)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x6FC58B0", Offset = "0x6FC48B0", VA = "0x186FC58B0")]
		public void ClearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x6FC5850", Offset = "0x6FC4850", VA = "0x186FC5850")]
		public void ClearUnityRigidbodyVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x6FC57F0", Offset = "0x6FC47F0", VA = "0x186FC57F0")]
		public void ClearLinearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x6FC5790", Offset = "0x6FC4790", VA = "0x186FC5790")]
		public void ClearAngularVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x6FC67F0", Offset = "0x6FC57F0", VA = "0x186FC67F0")]
		public void ResetVelocityWorldSpace(Vector3 JLAGCBDIOCE, Vector3 EDDEDOBFGPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x6FC66F0", Offset = "0x6FC56F0", VA = "0x186FC66F0")]
		public void ResetVelocityLocalSpace(Vector3 OBEPKPEDLHP, Vector3 ABBPNJFJIFG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x6FC65B0", Offset = "0x6FC55B0", VA = "0x186FC65B0")]
		public void ResetLinearVelocityLocalSpace(Vector3 OBEPKPEDLHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x6FC6D80", Offset = "0x6FC5D80", VA = "0x186FC6D80")]
		public bool SweepTest(Vector3 KDJEBHMIDDA, [Out] RaycastHit AFHFMMLDFGN, float PNEKGHHAGPJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x6FC6000", Offset = "0x6FC5000", VA = "0x186FC6000")]
		public bool IsSleeping()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x6FC6D20", Offset = "0x6FC5D20", VA = "0x186FC6D20")]
		public void Sleep()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x6FC6E90", Offset = "0x6FC5E90", VA = "0x186FC6E90")]
		public void WakeUp()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x6FC5160", Offset = "0x6FC4160", VA = "0x186FC5160")]
		public void AddShouldHaveUnityRigidbodyToken(object OEDJKICDDGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x6FC64D0", Offset = "0x6FC54D0", VA = "0x186FC64D0")]
		public void RemoveShouldHaveUnityRigidbodyToken(object OEDJKICDDGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x6FC5500", Offset = "0x6FC4500", VA = "0x186FC5500")]
		public void ApplyForceVelocityChange(IFHGOPCKPNL JGPGGDILHJP, Vector3 FOFCEMPLBMF, float PMHFDGEEHMA, float CKOJHMCFDFN = 8f, float DAPEKAPEIGC = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x6FC5460", Offset = "0x6FC4460", VA = "0x186FC5460")]
		public void ApplyAngularVelocityChange(NDHCMAFIHCP DMCPDILGENE, Vector3 CCIKDGBKHJI, float PFIFJDPLMHF = float.PositiveInfinity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x6FC55C0", Offset = "0x6FC45C0", VA = "0x186FC55C0")]
		[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
		public void ApplyTorqueAngularVelocityChangeDeprecated(NDHCMAFIHCP DMCPDILGENE, Vector3 ADNGPFKNGFI, float NBNJNGGMAEO = 7f, float JPGDHDCNCHB = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x6FC5390", Offset = "0x6FC4390", VA = "0x186FC5390")]
		public bool AllowedScaleChange(float BELNDHOBICH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x6FC52C0", Offset = "0x6FC42C0", VA = "0x186FC52C0")]
		public void AddWorldSpaceVelocityInHierarchyParentOverride(RigidbodyEx MMELNEJHCGH, object OEDJKICDDGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x6FC6540", Offset = "0x6FC5540", VA = "0x186FC6540")]
		public void RemoveWorldSpaceVelocityInHierarchyParentOverride(object OEDJKICDDGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x6FC7090", Offset = "0x6FC6090", VA = "0x186FC7090")]
		public RigidbodyEx()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x9554A0", Offset = "0x9544A0", VA = "0x1809554A0", Slot = "4")]
		private GameObject FPDGFGKJAJD()
		{
			return null;
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x88EDF0", Offset = "0x88DDF0", VA = "0x18088EDF0", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x6FB34D0", Offset = "0x6FB24D0", VA = "0x186FB34D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x869510", Offset = "0x868510", VA = "0x180869510", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public ONEPIAJLOFA OJAANGDCNKL
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x8687D0", Offset = "0x8677D0", VA = "0x1808687D0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x6FB1F80", Offset = "0x6FB0F80", VA = "0x186FB1F80", Slot = "7")]
	public void InitReferences(HODPOPFOFDD PDKMAMNDBJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x6FB1EF0", Offset = "0x6FB0EF0", VA = "0x186FB1EF0", Slot = "6")]
	public APLBGFGJNCA DJOBDPAJLOD(RigidbodyEx HOIOIPJLNDO, MIAGEIJEICK FHNKDHIILBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x86E790", Offset = "0x86D790", VA = "0x18086E790")]
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
		[Cpp2IlInjected.Address(RVA = "0x6FC4B80", Offset = "0x6FC3B80", VA = "0x186FC4B80")]
		protected void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x6FC4BC0", Offset = "0x6FC3BC0", VA = "0x186FC4BC0")]
		protected void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x6FC4BA0", Offset = "0x6FC3BA0", VA = "0x186FC4BA0")]
		protected void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x866350", Offset = "0x865350", VA = "0x180866350")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsNotYetUpdated([Optional] string NFOHONOFFAP, [Optional] UnityEngine.Object FFHIJMOJNAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x866350", Offset = "0x865350", VA = "0x180866350")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsAlreadyUpdated([Optional] string NFOHONOFFAP, [Optional] UnityEngine.Object FFHIJMOJNAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x6FC4CD0", Offset = "0x6FC3CD0", VA = "0x186FC4CD0")]
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
		[Cpp2IlInjected.Address(RVA = "0x866350", Offset = "0x865350", VA = "0x180866350", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x875BC0", Offset = "0x874BC0", VA = "0x180875BC0", Slot = "4")]
		public Vector3 NFABBLEHBOJ()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x875BC0", Offset = "0x874BC0", VA = "0x180875BC0", Slot = "5")]
		public Vector3 HOCEDEBJEEI()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x86E790", Offset = "0x86D790", VA = "0x18086E790")]
		public OOOPBILHDOE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public static NBGFPCGNHAJ GHIDIDFAAIB
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x6FB0250", Offset = "0x6FAF250", VA = "0x186FB0250")]
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
		[Cpp2IlInjected.Address(RVA = "0x866360", Offset = "0x865360", VA = "0x180866360", Slot = "22")]
		get
		{
			return default(AAEGPHPJNLD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public GMBPJONDGEK LPFBGACKLHF
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x86BA30", Offset = "0x86AA30", VA = "0x18086BA30", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x86B930", Offset = "0x86A930", VA = "0x18086B930")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public GameObject CHNINBIEDNN
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x9F5AC0", Offset = "0x9F4AC0", VA = "0x1809F5AC0", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x9D46C0", Offset = "0x9D36C0", VA = "0x1809D46C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public Transform ODNLGPAEKMF
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x6FBA4C0", Offset = "0x6FB94C0", VA = "0x186FBA4C0", Slot = "26")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public Rigidbody IIPBAHLFLID
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x6FBC3F0", Offset = "0x6FBB3F0", VA = "0x186FBC3F0", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public APLBGFGJNCA EGEBOODOFAP
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x6FB8FC0", Offset = "0x6FB7FC0", VA = "0x186FB8FC0", Slot = "27")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x6FB8550", Offset = "0x6FB7550", VA = "0x186FB8550", Slot = "28")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public int OBEGLHIDBFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x6FB81C0", Offset = "0x6FB71C0", VA = "0x186FB81C0", Slot = "31")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public APLBGFGJNCA JJGALJKCIFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x6FB9110", Offset = "0x6FB8110", VA = "0x186FB9110", Slot = "29")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public bool OGKMLGMAMJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x6FB6C40", Offset = "0x6FB5C40", VA = "0x186FB6C40", Slot = "138")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public bool LNOIEOBPGOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x6FB7C50", Offset = "0x6FB6C50", VA = "0x186FB7C50", Slot = "32")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public bool HLOCEFHJFJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x6FBA600", Offset = "0x6FB9600", VA = "0x186FBA600", Slot = "33")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public NBGFPCGNHAJ MDIDEKBEBLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x6FB8610", Offset = "0x6FB7610", VA = "0x186FB8610", Slot = "34")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x6FB8E70", Offset = "0x6FB7E70", VA = "0x186FB8E70", Slot = "35")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public GDLMMBKDOFD PDHMDHCJJAN
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x6FB9E60", Offset = "0x6FB8E60", VA = "0x186FB9E60", Slot = "36")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x6FB7CA0", Offset = "0x6FB6CA0", VA = "0x186FB7CA0", Slot = "37")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public float KHBCBMICPIE
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x6FB7840", Offset = "0x6FB6840", VA = "0x186FB7840", Slot = "38")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x6FB9640", Offset = "0x6FB8640", VA = "0x186FB9640", Slot = "39")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public Vector3 LPLJJCMDAJF
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x6FB9210", Offset = "0x6FB8210", VA = "0x186FB9210", Slot = "40")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x6FBB0D0", Offset = "0x6FBA0D0", VA = "0x186FBB0D0", Slot = "41")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public Vector3 GGAIONLLBJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x6FB9EB0", Offset = "0x6FB8EB0", VA = "0x186FB9EB0", Slot = "42")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x6FB8470", Offset = "0x6FB7470", VA = "0x186FB8470", Slot = "43")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public Vector3 PFPOLMCKFGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x6FB96A0", Offset = "0x6FB86A0", VA = "0x186FB96A0", Slot = "44")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x6FB93E0", Offset = "0x6FB83E0", VA = "0x186FB93E0", Slot = "45")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public Vector3 MGBDEJCEECD
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x6FBB2C0", Offset = "0x6FBA2C0", VA = "0x186FBB2C0", Slot = "46")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x6FB9BA0", Offset = "0x6FB8BA0", VA = "0x186FB9BA0", Slot = "47")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public bool OFLEHEDDMGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x6FBC520", Offset = "0x6FBB520", VA = "0x186FBC520", Slot = "139")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public bool AFEJNPNMCAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x6FB9DB0", Offset = "0x6FB8DB0", VA = "0x186FB9DB0", Slot = "48")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public bool DFJDMNDBIML
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x6FB7B70", Offset = "0x6FB6B70", VA = "0x186FB7B70", Slot = "49")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public bool HMPBHMHCEBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x6FB6D50", Offset = "0x6FB5D50", VA = "0x186FB6D50", Slot = "50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public Vector3 EDCABHFAAFE
	{
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x6FB6DA0", Offset = "0x6FB5DA0", VA = "0x186FB6DA0", Slot = "51")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public Vector3 IKDJAIOOJFG
	{
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x6FBC440", Offset = "0x6FBB440", VA = "0x186FBC440", Slot = "52")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public Vector3 LLCHMCEGACO
	{
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x6FB6ED0", Offset = "0x6FB5ED0", VA = "0x186FB6ED0", Slot = "53")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x6FB8C10", Offset = "0x6FB7C10", VA = "0x186FB8C10", Slot = "54")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public Vector3 DMKBNHANJAP
	{
		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x6FBB400", Offset = "0x6FBA400", VA = "0x186FBB400", Slot = "55")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public float BOLEMMHMCAB
	{
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x6FBA1C0", Offset = "0x6FB91C0", VA = "0x186FBA1C0", Slot = "56")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public float JCPNADANAGB
	{
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x6FB6BF0", Offset = "0x6FB5BF0", VA = "0x186FB6BF0", Slot = "57")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x6FB91B0", Offset = "0x6FB81B0", VA = "0x186FB91B0", Slot = "58")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public Vector3 OGIAMCOBEDN
	{
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x6FB78F0", Offset = "0x6FB68F0", VA = "0x186FB78F0", Slot = "59")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public Quaternion ILIHBKBCLNO
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x6FB8A40", Offset = "0x6FB7A40", VA = "0x186FB8A40", Slot = "60")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public float JGIJMIECAMO
	{
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x6FBAD00", Offset = "0x6FB9D00", VA = "0x186FBAD00", Slot = "62")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x6FBB070", Offset = "0x6FBA070", VA = "0x186FBB070", Slot = "63")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public float OINHMCCHBFI
	{
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x6FB7D60", Offset = "0x6FB6D60", VA = "0x186FB7D60", Slot = "64")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x6FBB540", Offset = "0x6FBA540", VA = "0x186FBB540", Slot = "65")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public bool MAIOGPMEPHO
	{
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x6FB6FB0", Offset = "0x6FB5FB0", VA = "0x186FB6FB0", Slot = "66")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x6FB7D00", Offset = "0x6FB6D00", VA = "0x186FB7D00", Slot = "67")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public AHOPCOINALC MOCDPHINOGF
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x6FBB270", Offset = "0x6FBA270", VA = "0x186FBB270", Slot = "68")]
		get
		{
			return default(AHOPCOINALC);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x6FBA5A0", Offset = "0x6FB95A0", VA = "0x186FBA5A0", Slot = "69")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public bool EJAIKGPDIBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x6FB7280", Offset = "0x6FB6280", VA = "0x186FB7280", Slot = "70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public Transform HPKOOIKHDEI
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x6FB6A20", Offset = "0x6FB5A20", VA = "0x186FB6A20", Slot = "71")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	public Vector3 OFCPGHABHFO
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x6FB8ED0", Offset = "0x6FB7ED0", VA = "0x186FB8ED0", Slot = "72")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x6FBA400", Offset = "0x6FB9400", VA = "0x186FBA400", Slot = "73")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public float ENGNAMJBAEK
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x6FB75D0", Offset = "0x6FB65D0", VA = "0x186FB75D0", Slot = "74")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x6FBBD90", Offset = "0x6FBAD90", VA = "0x186FBBD90", Slot = "75")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public float HDCDFFDAKOA
	{
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x6FBAA50", Offset = "0x6FB9A50", VA = "0x186FBAA50", Slot = "76")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x6FBAB50", Offset = "0x6FB9B50", VA = "0x186FBAB50", Slot = "77")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public Quaternion HEDBLFNKKEE
	{
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x6FBB9C0", Offset = "0x6FBA9C0", VA = "0x186FBB9C0", Slot = "78")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x6FBAF60", Offset = "0x6FB9F60", VA = "0x186FBAF60", Slot = "79")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	public Vector3 ABAOOCCJCCH
	{
		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x6FB9160", Offset = "0x6FB8160", VA = "0x186FB9160", Slot = "80")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x6FBA170", Offset = "0x6FB9170", VA = "0x186FBA170", Slot = "81")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public Quaternion JHHONLHGLCH
	{
		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x6FB8F80", Offset = "0x6FB7F80", VA = "0x186FB8F80", Slot = "82")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x6FBB5A0", Offset = "0x6FBA5A0", VA = "0x186FBB5A0", Slot = "83")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public RigidbodyConstraints MNFAOBCAHEG
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x6FBB6F0", Offset = "0x6FBA6F0", VA = "0x186FBB6F0", Slot = "84")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x6FBB3A0", Offset = "0x6FBA3A0", VA = "0x186FBB3A0", Slot = "85")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public bool NJHCAMDGLGE
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x6FB77F0", Offset = "0x6FB67F0", VA = "0x186FB77F0", Slot = "86")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x6FB9CF0", Offset = "0x6FB8CF0", VA = "0x186FB9CF0", Slot = "87")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	public CollisionDetectionMode AIEMLBIPKKK
	{
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x6FBAE90", Offset = "0x6FB9E90", VA = "0x186FBAE90", Slot = "88")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x6FBB960", Offset = "0x6FBA960", VA = "0x186FBB960", Slot = "89")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public bool GGPIKHKADAE
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x6FBAD50", Offset = "0x6FB9D50", VA = "0x186FBAD50", Slot = "140")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public bool AFHIINLOJFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x6FB9F90", Offset = "0x6FB8F90", VA = "0x186FB9F90", Slot = "90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event HJNBIKAPNHI MEJFDLJMBHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x6FB8230", Offset = "0x6FB7230", VA = "0x186FB8230", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x6FB7FD0", Offset = "0x6FB6FD0", VA = "0x186FB7FD0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	public event HJNBIKAPNHI CCIOFDBKGEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x6FB68C0", Offset = "0x6FB58C0", VA = "0x186FB68C0", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x6FBBAD0", Offset = "0x6FBAAD0", VA = "0x186FBBAD0", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000019")]
	public event JHDGOPNJJCO HEJFAKOONNE
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x6FBACA0", Offset = "0x6FB9CA0", VA = "0x186FBACA0", Slot = "18")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x6FB8030", Offset = "0x6FB7030", VA = "0x186FB8030", Slot = "19")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	public event HJNBIKAPNHI LLGAAAIHHIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x6FBBD30", Offset = "0x6FBAD30", VA = "0x186FBBD30", Slot = "8")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x6FBB4E0", Offset = "0x6FBA4E0", VA = "0x186FBB4E0", Slot = "9")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	public event HJNBIKAPNHI CGOADBPPEDL
	{
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x6FBC230", Offset = "0x6FBB230", VA = "0x186FBC230", Slot = "14")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x6FBA2F0", Offset = "0x6FB92F0", VA = "0x186FBA2F0", Slot = "15")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001C")]
	public event HJNBIKAPNHI GFKOIMCPIOF
	{
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x6FB94C0", Offset = "0x6FB84C0", VA = "0x186FB94C0", Slot = "16")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x6FB6E70", Offset = "0x6FB5E70", VA = "0x186FB6E70", Slot = "17")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001D")]
	public event Action<HPJFBALBIOJ, HPJFBALBIOJ> FPKHALMDLDG
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x6FBBE00", Offset = "0x6FBAE00", VA = "0x186FBBE00", Slot = "20")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x6FB9B40", Offset = "0x6FB8B40", VA = "0x186FB9B40", Slot = "21")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001E")]
	public event HJNBIKAPNHI OLEHIOMBLOL
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x6FB7A20", Offset = "0x6FB6A20", VA = "0x186FB7A20", Slot = "12")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x6FB85B0", Offset = "0x6FB75B0", VA = "0x186FB85B0", Slot = "13")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001F")]
	public event HJNBIKAPNHI EFMEMIAAGBB
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x6FB6810", Offset = "0x6FB5810", VA = "0x186FB6810", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x6FBC290", Offset = "0x6FBB290", VA = "0x186FBC290", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x6FBC5B0", Offset = "0x6FBB5B0", VA = "0x186FBC5B0")]
	public LECKHBKBLIE(GameObject INALOLPJOHI, RigidbodyEx KHBLFNBEAMA, PCNLIDDLILB MFNJBGPIIEN, [In] MIAGEIJEICK FHNKDHIILBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x6FBBE60", Offset = "0x6FBAE60", VA = "0x186FBBE60", Slot = "136")]
	protected virtual void PBDFIEEPJDP(PCNLIDDLILB MFNJBGPIIEN, MIAGEIJEICK FHNKDHIILBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x6FB8090", Offset = "0x6FB7090", VA = "0x186FB8090", Slot = "137")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x6FBB740", Offset = "0x6FBA740", VA = "0x186FBB740", Slot = "91")]
	public void NJNJFFLKLJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x6FB6D00", Offset = "0x6FB5D00", VA = "0x186FB6D00", Slot = "92")]
	public void ANKEHACNMHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x6FBB050", Offset = "0x6FBA050", VA = "0x186FBB050", Slot = "93")]
	public void LOHBDBMDNNP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x6FBAEE0", Offset = "0x6FB9EE0", VA = "0x186FBAEE0")]
	private void LKGMHCOOGEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x6FBB8E0", Offset = "0x6FBA8E0", VA = "0x186FBB8E0", Slot = "30")]
	public APLBGFGJNCA NNPIKIFMACD(int LLPJHIPCNFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x6FB9C80", Offset = "0x6FB8C80", VA = "0x186FB9C80", Slot = "95")]
	public void JBIJAJOHEMP(APLBGFGJNCA CBAEIEAPLIH, bool FFPHPJEJBKL = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x6FBBA70", Offset = "0x6FBAA70", VA = "0x186FBBA70", Slot = "96")]
	public void OELMKIPJBIG(object OEDJKICDDGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x6FB6CA0", Offset = "0x6FB5CA0", VA = "0x186FB6CA0", Slot = "97")]
	public void ALDPGBMDKBE(object OEDJKICDDGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x6FB8B10", Offset = "0x6FB7B10", VA = "0x186FB8B10", Slot = "98")]
	public Vector3 FHOLLECDNPL(Vector3 GAIBCOAKDKC)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x6FB9010", Offset = "0x6FB8010", VA = "0x186FB9010", Slot = "99")]
	public Vector3 GIBOAKBIOBF(Vector3 JPHCCCIGOIO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x6FB6D00", Offset = "0x6FB5D00", VA = "0x186FB6D00", Slot = "100")]
	public void DNCLFMGGGJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x6FB79D0", Offset = "0x6FB69D0", VA = "0x186FB79D0", Slot = "101")]
	public void DANBDBPOFDB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x6FB92F0", Offset = "0x6FB82F0", VA = "0x186FB92F0", Slot = "102")]
	public void HOBKCMKFCLE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x6FB7A80", Offset = "0x6FB6A80", VA = "0x186FB7A80", Slot = "103")]
	public void DEBGMMCHMJM(Vector3 JLAGCBDIOCE, Vector3 EDDEDOBFGPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x6FBBB30", Offset = "0x6FBAB30", VA = "0x186FBBB30", Slot = "104")]
	public void OFGCKBHIDPB(Vector3 OBEPKPEDLHP, Vector3 ABBPNJFJIFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x6FBC150", Offset = "0x6FBB150", VA = "0x186FBC150", Slot = "105")]
	public void PBEKBHIAIFL(Vector3 IJLKCHGFNBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x6FBBC70", Offset = "0x6FBAC70", VA = "0x186FBBC70", Slot = "106")]
	public void OHMJEBOOCPL(IFHGOPCKPNL JGPGGDILHJP, Vector3 FOFCEMPLBMF, float PMHFDGEEHMA, float CKOJHMCFDFN = 8f, float DAPEKAPEIGC = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x6FB9340", Offset = "0x6FB8340", VA = "0x186FB9340", Slot = "107")]
	public void IAAPNEJDAPI(NDHCMAFIHCP DMCPDILGENE, Vector3 CCIKDGBKHJI, float PFIFJDPLMHF = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x6FBA350", Offset = "0x6FB9350", VA = "0x186FBA350", Slot = "108")]
	[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
	public void JNLCOADNGGC(NDHCMAFIHCP DMCPDILGENE, Vector3 ADNGPFKNGFI, float NBNJNGGMAEO = 7f, float JPGDHDCNCHB = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x6FB6920", Offset = "0x6FB5920", VA = "0x186FB6920", Slot = "109")]
	public Vector3 AEKAOILCHOO(Vector3 CBAEIEAPLIH)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x6FB74D0", Offset = "0x6FB64D0", VA = "0x186FB74D0", Slot = "110")]
	public Vector3 CHGJLBAAOOC(Vector3 CBAEIEAPLIH)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x6FB7000", Offset = "0x6FB6000", VA = "0x186FB7000", Slot = "111")]
	public void BFJGNAHHNLH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x6FB89D0", Offset = "0x6FB79D0", VA = "0x186FB89D0", Slot = "112")]
	public void FHGLNMDOHBB(APLBGFGJNCA MMELNEJHCGH, object OEDJKICDDGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x6FB67B0", Offset = "0x6FB57B0", VA = "0x186FB67B0", Slot = "113")]
	public void AAMDKFFGMMO(object OEDJKICDDGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x6FBA650", Offset = "0x6FB9650", VA = "0x186FBA650", Slot = "61")]
	public void KDALBOFGHHC((Quaternion rot, Vector3 moments) GIALOAJHHIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x6FB9E10", Offset = "0x6FB8E10", VA = "0x186FB9E10", Slot = "114")]
	public void JFEFDBPFKAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x6FB7050", Offset = "0x6FB6050", VA = "0x186FB7050", Slot = "115")]
	public void BGIAMMFHOEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x6FBB220", Offset = "0x6FBA220", VA = "0x186FBB220", Slot = "116")]
	public void MFCGGLFKNLK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x6FB6BA0", Offset = "0x6FB5BA0", VA = "0x186FB6BA0", Slot = "117")]
	public bool AGBCHGFAEEO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x6FBAC50", Offset = "0x6FB9C50", VA = "0x186FBAC50", Slot = "94")]
	public void KPCLKJCNCKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x6FBBC20", Offset = "0x6FBAC20", VA = "0x186FBBC20", Slot = "118")]
	public void OGFNCOIHMFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x6FB7890", Offset = "0x6FB6890", VA = "0x186FB7890", Slot = "119")]
	public void CNBBAJCBBGF(object OEDJKICDDGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x6FBB880", Offset = "0x6FBA880", VA = "0x186FBB880", Slot = "120")]
	public void NLNABJAHOLE(object OEDJKICDDGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x6FBB1B0", Offset = "0x6FBA1B0", VA = "0x186FBB1B0", Slot = "121")]
	public void MEPPPGODBIL(object OEDJKICDDGA, bool OKDLNAIMGHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x6FB75F0", Offset = "0x6FB65F0", VA = "0x186FB75F0", Slot = "122")]
	public void CJEDGLMMBDC(Vector3 JLPKCGDHNKG, Quaternion GDJCCIDIKIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x6FB7DB0", Offset = "0x6FB6DB0", VA = "0x186FB7DB0", Slot = "123")]
	public void DLMGOANOKML(Vector3 KFJLMDEKNOI, Quaternion NPNKNILIGCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x6FB9D50", Offset = "0x6FB8D50", VA = "0x186FB9D50", Slot = "124")]
	public bool JDDFJCGKFMK(float BELNDHOBICH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x6FB95E0", Offset = "0x6FB85E0", VA = "0x186FB95E0", Slot = "125")]
	public void ICCHKCLABFP(object OEDJKICDDGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x6FB72D0", Offset = "0x6FB62D0", VA = "0x186FB72D0", Slot = "126")]
	public void BNCCABKMMOJ(object OEDJKICDDGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x6FB8160", Offset = "0x6FB7160", VA = "0x186FB8160", Slot = "127")]
	public void EBGLEEGCKPH(object OEDJKICDDGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x6FBA110", Offset = "0x6FB9110", VA = "0x186FBA110", Slot = "128")]
	public void JKEKIFFHNOK(object OEDJKICDDGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x6FBA210", Offset = "0x6FB9210", VA = "0x186FBA210", Slot = "129")]
	public void JMNAKONBCGM(Vector3 BAKDLGCFEEB, ForceMode CGHFFMJLLOB = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x6FB70A0", Offset = "0x6FB60A0", VA = "0x186FB70A0", Slot = "130")]
	public void BIAEKBICOOJ(Vector3 BAKDLGCFEEB, Vector3 MOIICCIPACK, ForceMode CGHFFMJLLOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x6FBAA70", Offset = "0x6FB9A70", VA = "0x186FBAA70", Slot = "131")]
	public void KMGFCLKLIKC(Vector3 OAEKPIGFLHH, ForceMode CGHFFMJLLOB = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x6FB66D0", Offset = "0x6FB56D0", VA = "0x186FB66D0", Slot = "132")]
	public void AADNPNFECGO(Vector3 OAEKPIGFLHH, ForceMode CGHFFMJLLOB = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x6FB7430", Offset = "0x6FB6430", VA = "0x186FB7430", Slot = "133")]
	public bool CCOPMDDFIGI(Vector3 KDJEBHMIDDA, [Out] RaycastHit AFHFMMLDFGN, float PNEKGHHAGPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x6FBA550", Offset = "0x6FB9550", VA = "0x186FBA550", Slot = "134")]
	public void KAAHHJDKNAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x6FBC570", Offset = "0x6FBB570", VA = "0x186FBC570", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x6FB7F00", Offset = "0x6FB6F00", VA = "0x186FB7F00")]
	private void DNABJCBKPPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x6FBB5E0", Offset = "0x6FBA5E0", VA = "0x186FBB5E0")]
	private void NDPJBGPCGLG(APLBGFGJNCA HHMPHBNGMGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x6FB8290", Offset = "0x6FB7290", VA = "0x186FB8290")]
	private void EEJCCGALIEH(APLBGFGJNCA HHMPHBNGMGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x6FBC340", Offset = "0x6FBB340", VA = "0x186FBC340")]
	private void PEOKLMJIOBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x6FB7330", Offset = "0x6FB6330", VA = "0x186FB7330")]
	private void CBHAEOGGOOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x6FB8CF0", Offset = "0x6FB7CF0", VA = "0x186FB8CF0")]
	private void FJMINJPLNHH(APLBGFGJNCA JDLKLHDHDEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x6FB6600", Offset = "0x6FB5600", VA = "0x186FB6600")]
	private void AADHAIMFKPJ(APLBGFGJNCA HHMPHBNGMGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x6FB71B0", Offset = "0x6FB61B0", VA = "0x186FB71B0")]
	private void BKPHMNCBNLA(APLBGFGJNCA HHMPHBNGMGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x6FB6A30", Offset = "0x6FB5A30", VA = "0x186FB6A30")]
	private void AFGMPPIGCEI(GMBPJONDGEK HHMPHBNGMGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x6FB9780", Offset = "0x6FB8780", VA = "0x186FB9780", Slot = "141")]
	protected virtual void ILAKKIPIAGM(GMBPJONDGEK HOIOIPJLNDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x6FBA730", Offset = "0x6FB9730", VA = "0x186FBA730")]
	protected void KGDHOPDFPEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x6FB8660", Offset = "0x6FB7660", VA = "0x186FB8660")]
	protected void ENOKBICIDGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x6FB9520", Offset = "0x6FB8520", VA = "0x186FB9520", Slot = "142")]
	protected virtual IDisposable IBGPALCFHDD()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal static class GHMPHGLPLOH
{
	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x6FB1DB0", Offset = "0x6FB0DB0", VA = "0x186FB1DB0")]
	public static APLBGFGJNCA FHOPLAEMONJ(this APLBGFGJNCA HOIOIPJLNDO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x6FB1E70", Offset = "0x6FB0E70", VA = "0x186FB1E70")]
	public static bool OENLCNBNGPJ(this APLBGFGJNCA HOIOIPJLNDO, APLBGFGJNCA GNFLHKHMMIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x6FB1CC0", Offset = "0x6FB0CC0", VA = "0x186FB1CC0")]
	public static bool BOBCHMKELHI(this APLBGFGJNCA HOIOIPJLNDO, APLBGFGJNCA NAPOIPGFDKM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x6FB1C70", Offset = "0x6FB0C70", VA = "0x186FB1C70")]
	public static GMBPJONDGEK ABONPMOLODD(this APLBGFGJNCA LIGKCFOOPNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x6FB1D40", Offset = "0x6FB0D40", VA = "0x186FB1D40")]
	public static LECKHBKBLIE DGOBLDGGNIM(this APLBGFGJNCA LIGKCFOOPNO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class DGKDDAHJNMC : ONEPIAJLOFA
{
	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x6FB16C0", Offset = "0x6FB06C0", VA = "0x186FB16C0", Slot = "19")]
	public APLBGFGJNCA DJOBDPAJLOD(RigidbodyEx HOIOIPJLNDO, MIAGEIJEICK FHNKDHIILBL, PCNLIDDLILB MFNJBGPIIEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x866360", Offset = "0x865360", VA = "0x180866360", Slot = "4")]
	public DMGGNDNGING OMFFAMKPKOE(APLBGFGJNCA LIGKCFOOPNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x866360", Offset = "0x865360", VA = "0x180866360", Slot = "5")]
	public HAINGGMEBCP JIIPKKBNDKE(APLBGFGJNCA LIGKCFOOPNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x866360", Offset = "0x865360", VA = "0x180866360", Slot = "6")]
	public CPFOCAOAKBF GJIGFCGBIJF(APLBGFGJNCA LIGKCFOOPNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x866360", Offset = "0x865360", VA = "0x180866360", Slot = "7")]
	public MCHAOOGFIAG JFKKLEBDCCF(APLBGFGJNCA LIGKCFOOPNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x866360", Offset = "0x865360", VA = "0x180866360", Slot = "8")]
	public CJEAPFBINIP APAJABFGLEM(APLBGFGJNCA LIGKCFOOPNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x866360", Offset = "0x865360", VA = "0x180866360", Slot = "9")]
	public KMKPHBLDIIH PPMFHCDOJPB(APLBGFGJNCA LIGKCFOOPNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x866360", Offset = "0x865360", VA = "0x180866360", Slot = "10")]
	public OMFLJILKCBJ IKAPCKKANAN(APLBGFGJNCA LIGKCFOOPNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x866360", Offset = "0x865360", VA = "0x180866360", Slot = "11")]
	public BNCMPGAJGPD JAHDMOFAMIC(APLBGFGJNCA LIGKCFOOPNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x866360", Offset = "0x865360", VA = "0x180866360", Slot = "12")]
	public AKBJNHGNECB HNHFBNANCFG(APLBGFGJNCA LIGKCFOOPNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x866360", Offset = "0x865360", VA = "0x180866360", Slot = "13")]
	public LLMHJHKEOMO PHJHFOBLDJB(APLBGFGJNCA LIGKCFOOPNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x866360", Offset = "0x865360", VA = "0x180866360")]
	public FNDLGAMMLDH JBDODAFFNKP(APLBGFGJNCA LIGKCFOOPNO, [In] MIAGEIJEICK FHNKDHIILBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x866360", Offset = "0x865360", VA = "0x180866360")]
	public NIDOBNBOINJ PDLNIGDNPPB(APLBGFGJNCA LIGKCFOOPNO, [In] MIAGEIJEICK FHNKDHIILBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x866360", Offset = "0x865360", VA = "0x180866360")]
	public BJEDNLOFOCD CJHNJJLCBBL(APLBGFGJNCA LIGKCFOOPNO, [In] MIAGEIJEICK FHNKDHIILBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x866360", Offset = "0x865360", VA = "0x180866360")]
	public MOALKNPEIEJ LHHFOALJJFI(APLBGFGJNCA LIGKCFOOPNO, [In] MIAGEIJEICK FHNKDHIILBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x866360", Offset = "0x865360", VA = "0x180866360")]
	public COKAFKIMNBP PNACPCHIFHK(APLBGFGJNCA LIGKCFOOPNO, [In] MIAGEIJEICK FHNKDHIILBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x86E790", Offset = "0x86D790", VA = "0x18086E790")]
	public DGKDDAHJNMC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x866360", Offset = "0x865360", VA = "0x180866360", Slot = "14")]
	private FNDLGAMMLDH EPLJPPJDEFK(APLBGFGJNCA LIGKCFOOPNO, [In] MIAGEIJEICK FHNKDHIILBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x866360", Offset = "0x865360", VA = "0x180866360", Slot = "15")]
	private NIDOBNBOINJ IILJPPOKJGM(APLBGFGJNCA LIGKCFOOPNO, [In] MIAGEIJEICK FHNKDHIILBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x866360", Offset = "0x865360", VA = "0x180866360", Slot = "16")]
	private BJEDNLOFOCD COGHFDIOKAE(APLBGFGJNCA LIGKCFOOPNO, [In] MIAGEIJEICK FHNKDHIILBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x866360", Offset = "0x865360", VA = "0x180866360", Slot = "17")]
	private MOALKNPEIEJ DNJDKOIFKLL(APLBGFGJNCA LIGKCFOOPNO, [In] MIAGEIJEICK FHNKDHIILBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x866360", Offset = "0x865360", VA = "0x180866360", Slot = "18")]
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
		[Cpp2IlInjected.Address(RVA = "0x6FBCCA0", Offset = "0x6FBBCA0", VA = "0x186FBCCA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x6FBCD00", Offset = "0x6FBBD00", VA = "0x186FBCD00", Slot = "20")]
	public void InitReferences(HODPOPFOFDD PDKMAMNDBJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x6FBCF30", Offset = "0x6FBBF30", VA = "0x186FBCF30", Slot = "4")]
	public DMGGNDNGING OMFFAMKPKOE(APLBGFGJNCA LIGKCFOOPNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x6FBCE90", Offset = "0x6FBBE90", VA = "0x186FBCE90", Slot = "5")]
	public HAINGGMEBCP JIIPKKBNDKE(APLBGFGJNCA LIGKCFOOPNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x6FBCA10", Offset = "0x6FBBA10", VA = "0x186FBCA10", Slot = "6")]
	public CPFOCAOAKBF GJIGFCGBIJF(APLBGFGJNCA LIGKCFOOPNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x6FBCDF0", Offset = "0x6FBBDF0", VA = "0x186FBCDF0", Slot = "7")]
	public MCHAOOGFIAG JFKKLEBDCCF(APLBGFGJNCA LIGKCFOOPNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x6FBC680", Offset = "0x6FBB680", VA = "0x186FBC680", Slot = "8")]
	public CJEAPFBINIP APAJABFGLEM(APLBGFGJNCA LIGKCFOOPNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x6FBD120", Offset = "0x6FBC120", VA = "0x186FBD120", Slot = "9")]
	public KMKPHBLDIIH PPMFHCDOJPB(APLBGFGJNCA LIGKCFOOPNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x6FBCC00", Offset = "0x6FBBC00", VA = "0x186FBCC00", Slot = "10")]
	public OMFLJILKCBJ IKAPCKKANAN(APLBGFGJNCA LIGKCFOOPNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x6FBCD50", Offset = "0x6FBBD50", VA = "0x186FBCD50", Slot = "11")]
	public BNCMPGAJGPD JAHDMOFAMIC(APLBGFGJNCA LIGKCFOOPNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x6FBCAB0", Offset = "0x6FBBAB0", VA = "0x186FBCAB0", Slot = "12")]
	public AKBJNHGNECB HNHFBNANCFG(APLBGFGJNCA LIGKCFOOPNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x6FBCFD0", Offset = "0x6FBBFD0", VA = "0x186FBCFD0", Slot = "13")]
	public LLMHJHKEOMO PHJHFOBLDJB(APLBGFGJNCA LIGKCFOOPNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x6FBC960", Offset = "0x6FBB960", VA = "0x186FBC960")]
	public FNDLGAMMLDH JBDODAFFNKP(APLBGFGJNCA LIGKCFOOPNO, [In] MIAGEIJEICK FHNKDHIILBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x6FBCB50", Offset = "0x6FBBB50", VA = "0x186FBCB50")]
	public NIDOBNBOINJ PDLNIGDNPPB(APLBGFGJNCA LIGKCFOOPNO, [In] MIAGEIJEICK FHNKDHIILBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x6FBC720", Offset = "0x6FBB720", VA = "0x186FBC720")]
	public BJEDNLOFOCD CJHNJJLCBBL(APLBGFGJNCA LIGKCFOOPNO, [In] MIAGEIJEICK FHNKDHIILBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x6FBC8B0", Offset = "0x6FBB8B0", VA = "0x186FBC8B0")]
	public MOALKNPEIEJ LHHFOALJJFI(APLBGFGJNCA LIGKCFOOPNO, [In] MIAGEIJEICK FHNKDHIILBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x6FBD070", Offset = "0x6FBC070", VA = "0x186FBD070")]
	public COKAFKIMNBP PNACPCHIFHK(APLBGFGJNCA LIGKCFOOPNO, [In] MIAGEIJEICK FHNKDHIILBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x6FBC7D0", Offset = "0x6FBB7D0", VA = "0x186FBC7D0", Slot = "19")]
	public APLBGFGJNCA DJOBDPAJLOD(RigidbodyEx HOIOIPJLNDO, MIAGEIJEICK FHNKDHIILBL, PCNLIDDLILB MFNJBGPIIEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x6FBD1C0", Offset = "0x6FBC1C0", VA = "0x186FBD1C0")]
	public LFNDKOCAEHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x6FBC960", Offset = "0x6FBB960", VA = "0x186FBC960", Slot = "14")]
	private FNDLGAMMLDH EPLJPPJDEFK(APLBGFGJNCA LIGKCFOOPNO, [In] MIAGEIJEICK FHNKDHIILBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x6FBCB50", Offset = "0x6FBBB50", VA = "0x186FBCB50", Slot = "15")]
	private NIDOBNBOINJ IILJPPOKJGM(APLBGFGJNCA LIGKCFOOPNO, [In] MIAGEIJEICK FHNKDHIILBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x6FBC720", Offset = "0x6FBB720", VA = "0x186FBC720", Slot = "16")]
	private BJEDNLOFOCD COGHFDIOKAE(APLBGFGJNCA LIGKCFOOPNO, [In] MIAGEIJEICK FHNKDHIILBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x6FBC8B0", Offset = "0x6FBB8B0", VA = "0x186FBC8B0", Slot = "17")]
	private MOALKNPEIEJ DNJDKOIFKLL(APLBGFGJNCA LIGKCFOOPNO, [In] MIAGEIJEICK FHNKDHIILBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x6FBD070", Offset = "0x6FBC070", VA = "0x186FBD070", Slot = "18")]
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
		[Cpp2IlInjected.Address(RVA = "0x6FB2E10", Offset = "0x6FB1E10", VA = "0x186FB2E10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public CollisionDetectionMode AIEMLBIPKKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x6FB3180", Offset = "0x6FB2180", VA = "0x186FB3180", Slot = "4")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x6FB33A0", Offset = "0x6FB23A0", VA = "0x186FB33A0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x6FB1910", Offset = "0x6FB0910", VA = "0x186FB1910")]
	public GNFHDNIIGIM(APLBGFGJNCA HOIOIPJLNDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x6FB3290", Offset = "0x6FB2290", VA = "0x186FB3290", Slot = "6")]
	public void NJNJFFLKLJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x6FB2FE0", Offset = "0x6FB1FE0", VA = "0x186FB2FE0", Slot = "9")]
	public void GFNCMGKLDEI(Rigidbody IBPJGMDGDIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x6FB2E60", Offset = "0x6FB1E60", VA = "0x186FB2E60", Slot = "7")]
	public void AALDBFMNNDA(bool PANMEHIHIBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x6FB2E70", Offset = "0x6FB1E70", VA = "0x186FB2E70", Slot = "8")]
	public void BJAKKKCFBND(bool PANMEHIHIBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x6FB2E80", Offset = "0x6FB1E80", VA = "0x186FB2E80", Slot = "10")]
	public bool CCOPMDDFIGI(Vector3 KDJEBHMIDDA, [Out] RaycastHit AFHFMMLDFGN, float PNEKGHHAGPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x6FB3060", Offset = "0x6FB2060", VA = "0x186FB3060")]
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
		[Cpp2IlInjected.Address(RVA = "0x6FB6110", Offset = "0x6FB5110", VA = "0x186FB6110", Slot = "6")]
		get
		{
			return default(AHOPCOINALC);
		}
		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x6FB6040", Offset = "0x6FB5040", VA = "0x186FB6040", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	private Transform MIGHMBDINDI
	{
		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x6FB5F70", Offset = "0x6FB4F70", VA = "0x186FB5F70", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000020")]
	public event Action<HPJFBALBIOJ, HPJFBALBIOJ> FPKHALMDLDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x6FB64C0", Offset = "0x6FB54C0", VA = "0x186FB64C0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x6FB5F90", Offset = "0x6FB4F90", VA = "0x186FB5F90", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x6FB6570", Offset = "0x6FB5570", VA = "0x186FB6570")]
	public JIDGJGHFGAG(APLBGFGJNCA HOIOIPJLNDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x6FB6250", Offset = "0x6FB5250", VA = "0x186FB6250", Slot = "8")]
	public void NJNJFFLKLJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x6FB5F20", Offset = "0x6FB4F20", VA = "0x186FB5F20", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x97F620", Offset = "0x97E620", VA = "0x18097F620", Slot = "11")]
	private void BOEPANBDJOK(HPJFBALBIOJ BBJCFJAGFJE, HPJFBALBIOJ BNCFEMNNLIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x866350", Offset = "0x865350", VA = "0x180866350", Slot = "12")]
	private void PAMHPOABJEB(bool CCMANGKMKPF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class APBPCDEOAND : ONEPIAJLOFA
{
	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x6FAF870", Offset = "0x6FAE870", VA = "0x186FAF870", Slot = "4")]
	public DMGGNDNGING OMFFAMKPKOE(APLBGFGJNCA LIGKCFOOPNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x6FAF750", Offset = "0x6FAE750", VA = "0x186FAF750", Slot = "5")]
	public HAINGGMEBCP JIIPKKBNDKE(APLBGFGJNCA LIGKCFOOPNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x6FAF170", Offset = "0x6FAE170", VA = "0x186FAF170", Slot = "6")]
	public CPFOCAOAKBF GJIGFCGBIJF(APLBGFGJNCA LIGKCFOOPNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x6FAF6D0", Offset = "0x6FAE6D0", VA = "0x186FAF6D0", Slot = "7")]
	public MCHAOOGFIAG JFKKLEBDCCF(APLBGFGJNCA LIGKCFOOPNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x6FAEB80", Offset = "0x6FADB80", VA = "0x186FAEB80", Slot = "8")]
	public CJEAPFBINIP APAJABFGLEM(APLBGFGJNCA LIGKCFOOPNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x6FAFB00", Offset = "0x6FAEB00", VA = "0x186FAFB00", Slot = "9")]
	public KMKPHBLDIIH PPMFHCDOJPB(APLBGFGJNCA LIGKCFOOPNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x6FAF4F0", Offset = "0x6FAE4F0", VA = "0x186FAF4F0", Slot = "10")]
	public OMFLJILKCBJ IKAPCKKANAN(APLBGFGJNCA LIGKCFOOPNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x6FAF610", Offset = "0x6FAE610", VA = "0x186FAF610", Slot = "11")]
	public BNCMPGAJGPD JAHDMOFAMIC(APLBGFGJNCA LIGKCFOOPNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x6FAF2A0", Offset = "0x6FAE2A0", VA = "0x186FAF2A0", Slot = "12")]
	public AKBJNHGNECB HNHFBNANCFG(APLBGFGJNCA LIGKCFOOPNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x6FAF960", Offset = "0x6FAE960", VA = "0x186FAF960", Slot = "13")]
	public LLMHJHKEOMO PHJHFOBLDJB(APLBGFGJNCA LIGKCFOOPNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x6FAF030", Offset = "0x6FAE030", VA = "0x186FAF030")]
	public FNDLGAMMLDH JBDODAFFNKP(APLBGFGJNCA LIGKCFOOPNO, [In] MIAGEIJEICK FHNKDHIILBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x6FAF360", Offset = "0x6FAE360", VA = "0x186FAF360")]
	public NIDOBNBOINJ PDLNIGDNPPB(APLBGFGJNCA LIGKCFOOPNO, [In] MIAGEIJEICK FHNKDHIILBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x6FAEC50", Offset = "0x6FADC50", VA = "0x186FAEC50")]
	public BJEDNLOFOCD CJHNJJLCBBL(APLBGFGJNCA LIGKCFOOPNO, [In] MIAGEIJEICK FHNKDHIILBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x6FAEEA0", Offset = "0x6FADEA0", VA = "0x186FAEEA0")]
	public MOALKNPEIEJ LHHFOALJJFI(APLBGFGJNCA LIGKCFOOPNO, [In] MIAGEIJEICK FHNKDHIILBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x6FAFA20", Offset = "0x6FAEA20", VA = "0x186FAFA20")]
	public COKAFKIMNBP PNACPCHIFHK(APLBGFGJNCA LIGKCFOOPNO, [In] MIAGEIJEICK FHNKDHIILBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x6FAED80", Offset = "0x6FADD80", VA = "0x186FAED80", Slot = "19")]
	public APLBGFGJNCA DJOBDPAJLOD(RigidbodyEx HOIOIPJLNDO, MIAGEIJEICK FHNKDHIILBL, PCNLIDDLILB MFNJBGPIIEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x86E790", Offset = "0x86D790", VA = "0x18086E790")]
	public APBPCDEOAND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x6FAF030", Offset = "0x6FAE030", VA = "0x186FAF030", Slot = "14")]
	private FNDLGAMMLDH EPLJPPJDEFK(APLBGFGJNCA LIGKCFOOPNO, [In] MIAGEIJEICK FHNKDHIILBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x6FAF360", Offset = "0x6FAE360", VA = "0x186FAF360", Slot = "15")]
	private NIDOBNBOINJ IILJPPOKJGM(APLBGFGJNCA LIGKCFOOPNO, [In] MIAGEIJEICK FHNKDHIILBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x6FAEC50", Offset = "0x6FADC50", VA = "0x186FAEC50", Slot = "16")]
	private BJEDNLOFOCD COGHFDIOKAE(APLBGFGJNCA LIGKCFOOPNO, [In] MIAGEIJEICK FHNKDHIILBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x6FAEEA0", Offset = "0x6FADEA0", VA = "0x186FAEEA0", Slot = "17")]
	private MOALKNPEIEJ DNJDKOIFKLL(APLBGFGJNCA LIGKCFOOPNO, [In] MIAGEIJEICK FHNKDHIILBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x6FAFA20", Offset = "0x6FAEA20", VA = "0x186FAFA20", Slot = "18")]
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
		[Cpp2IlInjected.Address(RVA = "0x6FB2E10", Offset = "0x6FB1E10", VA = "0x186FB2E10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	private bool EJAIKGPDIBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x6FB25E0", Offset = "0x6FB15E0", VA = "0x186FB25E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	private bool OGKMLGMAMJM
	{
		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x6FB2300", Offset = "0x6FB1300", VA = "0x186FB2300")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	private APLBGFGJNCA EGEBOODOFAP
	{
		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x6FB2890", Offset = "0x6FB1890", VA = "0x186FB2890")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x6FB1910", Offset = "0x6FB0910", VA = "0x186FB1910")]
	public GMHBPIMDNBF(APLBGFGJNCA HOIOIPJLNDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x6FB2B50", Offset = "0x6FB1B50", VA = "0x186FB2B50", Slot = "4")]
	public void JMNAKONBCGM(Vector3 BAKDLGCFEEB, ForceMode CGHFFMJLLOB = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x6FB28F0", Offset = "0x6FB18F0", VA = "0x186FB28F0")]
	private void ICJDOLFFBKN(Vector3 BAKDLGCFEEB, ForceMode CGHFFMJLLOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x6FB2360", Offset = "0x6FB1360", VA = "0x186FB2360", Slot = "5")]
	public void BIAEKBICOOJ(Vector3 BAKDLGCFEEB, Vector3 MOIICCIPACK, ForceMode CGHFFMJLLOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x6FB2CB0", Offset = "0x6FB1CB0", VA = "0x186FB2CB0", Slot = "6")]
	public void KMGFCLKLIKC(Vector3 OAEKPIGFLHH, ForceMode CGHFFMJLLOB = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x6FB2630", Offset = "0x6FB1630", VA = "0x186FB2630")]
	private void CKLIECOJBFF(Vector3 OAEKPIGFLHH, ForceMode CGHFFMJLLOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x6FB20A0", Offset = "0x6FB10A0", VA = "0x186FB20A0", Slot = "7")]
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
		[Cpp2IlInjected.Address(RVA = "0x932C30", Offset = "0x931C30", VA = "0x180932C30", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x6FB1760", Offset = "0x6FB0760", VA = "0x186FB1760", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x6FB1910", Offset = "0x6FB0910", VA = "0x186FB1910")]
	public EDMOALNEFNI(APLBGFGJNCA HOIOIPJLNDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(RVA = "0x6FB18E0", Offset = "0x6FB08E0", VA = "0x186FB18E0", Slot = "6")]
	public void GFNCMGKLDEI(Rigidbody IBPJGMDGDIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x6FB1870", Offset = "0x6FB0870", VA = "0x186FB1870", Slot = "7")]
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
		[Cpp2IlInjected.Address(RVA = "0x6FBF630", Offset = "0x6FBE630", VA = "0x186FBF630")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public APLBGFGJNCA EGEBOODOFAP
	{
		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x866E50", Offset = "0x865E50", VA = "0x180866E50", Slot = "28")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x6FBE930", Offset = "0x6FBD930", VA = "0x186FBE930", Slot = "29")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public APLBGFGJNCA JJGALJKCIFK
	{
		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x866DD0", Offset = "0x865DD0", VA = "0x180866DD0", Slot = "27")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public IReadOnlyList<APLBGFGJNCA> PNMELPFDNDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x866E00", Offset = "0x865E00", VA = "0x180866E00", Slot = "26")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000021")]
	public event HJNBIKAPNHI MEJFDLJMBHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x6FBE890", Offset = "0x6FBD890", VA = "0x186FBE890", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x6FBE6B0", Offset = "0x6FBD6B0", VA = "0x186FBE6B0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000022")]
	public event HJNBIKAPNHI CCIOFDBKGEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x6FBE030", Offset = "0x6FBD030", VA = "0x186FBE030", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x6FBFA70", Offset = "0x6FBEA70", VA = "0x186FBFA70", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000023")]
	public event JHDGOPNJJCO HEJFAKOONNE
	{
		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x6FBF730", Offset = "0x6FBE730", VA = "0x186FBF730", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x6FBE750", Offset = "0x6FBD750", VA = "0x186FBE750", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000024")]
	public event Action PCMNEHBAIEF
	{
		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x6FBF690", Offset = "0x6FBE690", VA = "0x186FBF690", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x6FBF930", Offset = "0x6FBE930", VA = "0x186FBF930", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000025")]
	public event Action FDAFOFJNFAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x6FBEB10", Offset = "0x6FBDB10", VA = "0x186FBEB10", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x6FBF7D0", Offset = "0x6FBE7D0", VA = "0x186FBF7D0", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000026")]
	public event Action<APLBGFGJNCA> FDKFJIJKDCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x6FBEBB0", Offset = "0x6FBDBB0", VA = "0x186FBEBB0", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x6FBF000", Offset = "0x6FBE000", VA = "0x186FBF000", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000027")]
	public event Action<APLBGFGJNCA> INMPJHKCHJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x6FBFD90", Offset = "0x6FBED90", VA = "0x186FBFD90", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x6FBED70", Offset = "0x6FBDD70", VA = "0x186FBED70", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000028")]
	public event Action HCNDPNJJECM
	{
		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x6FBF9D0", Offset = "0x6FBE9D0", VA = "0x186FBF9D0", Slot = "22")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x6FBE610", Offset = "0x6FBD610", VA = "0x186FBE610", Slot = "23")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000029")]
	public event Action<APLBGFGJNCA> GJMGPANENOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x6FBEE20", Offset = "0x6FBDE20", VA = "0x186FBEE20", Slot = "24")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x6FBE420", Offset = "0x6FBD420", VA = "0x186FBE420", Slot = "25")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600027B")]
	[Cpp2IlInjected.Address(RVA = "0x6FBFE40", Offset = "0x6FBEE40", VA = "0x186FBFE40")]
	public MHBCEOILOMI(APLBGFGJNCA HOIOIPJLNDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027C")]
	[Cpp2IlInjected.Address(RVA = "0x6FBE7F0", Offset = "0x6FBD7F0", VA = "0x186FBE7F0", Slot = "31")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000281")]
	[Cpp2IlInjected.Address(RVA = "0x6FBF0B0", Offset = "0x6FBE0B0", VA = "0x186FBF0B0", Slot = "30")]
	public void JBIJAJOHEMP(APLBGFGJNCA NAEADMGDGFI, bool FFPHPJEJBKL = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000282")]
	[Cpp2IlInjected.Address(RVA = "0x6FBE0D0", Offset = "0x6FBD0D0", VA = "0x186FBE0D0", Slot = "6")]
	public void AHDHBDBFBBE(APLBGFGJNCA JDLKLHDHDEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000283")]
	[Cpp2IlInjected.Address(RVA = "0x6FBFB10", Offset = "0x6FBEB10", VA = "0x186FBFB10", Slot = "7")]
	public void OMAFIMMNPKC(APLBGFGJNCA JDLKLHDHDEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(RVA = "0x6FBEC60", Offset = "0x6FBDC60", VA = "0x186FBEC60", Slot = "4")]
	public void GAMMKDIBDLH(APLBGFGJNCA HOIOIPJLNDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000285")]
	[Cpp2IlInjected.Address(RVA = "0x6FBE340", Offset = "0x6FBD340", VA = "0x186FBE340", Slot = "5")]
	public void AJAEINCGPLB(APLBGFGJNCA HOIOIPJLNDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000286")]
	[Cpp2IlInjected.Address(RVA = "0x6FBEA70", Offset = "0x6FBDA70", VA = "0x186FBEA70")]
	private void EPCICLNOMAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(RVA = "0x6FBE3E0", Offset = "0x6FBD3E0", VA = "0x186FBE3E0")]
	private void ALIKKNONPMB(APLBGFGJNCA JDLKLHDHDEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(RVA = "0x6FBE4D0", Offset = "0x6FBD4D0", VA = "0x186FBE4D0")]
	private void CEIOOEIFHDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x6FBEED0", Offset = "0x6FBDED0", VA = "0x186FBEED0")]
	private void GKDGKIINPEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x6FBE940", Offset = "0x6FBD940", VA = "0x186FBE940")]
	private void EKGNEMEGABM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(RVA = "0x6FBF870", Offset = "0x6FBE870", VA = "0x186FBF870")]
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
	[Cpp2IlInjected.Address(RVA = "0x6FB0190", Offset = "0x6FAF190", VA = "0x186FB0190")]
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
		[Cpp2IlInjected.Address(RVA = "0x869510", Offset = "0x868510", VA = "0x180869510", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public Vector3 EDCABHFAAFE
	{
		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x6FB0A40", Offset = "0x6FAFA40", VA = "0x186FB0A40", Slot = "6")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public Vector3 IKDJAIOOJFG
	{
		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x6FB1400", Offset = "0x6FB0400", VA = "0x186FB1400", Slot = "7")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	private Vector3 PFPOLMCKFGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x6FB11F0", Offset = "0x6FB01F0", VA = "0x186FB11F0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public APLBGFGJNCA JKFAJMIAILJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x6FB12E0", Offset = "0x6FB02E0", VA = "0x186FB12E0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x6FB15C0", Offset = "0x6FB05C0", VA = "0x186FB15C0")]
	public CLLOGGJMHEJ(APLBGFGJNCA HOIOIPJLNDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x6FB1390", Offset = "0x6FB0390", VA = "0x186FB1390", Slot = "8")]
	public void NLLPPNIMLMC(APLBGFGJNCA HHMPHBNGMGF, object OEDJKICDDGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x6FB1190", Offset = "0x6FB0190", VA = "0x186FB1190", Slot = "9")]
	public void HNAPJGELACK(object OEDJKICDDGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x6FB0A70", Offset = "0x6FAFA70", VA = "0x186FB0A70")]
	private Vector3 DFNJOFKKKMN()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x6FB0E00", Offset = "0x6FAFE00", VA = "0x186FB0E00")]
	private void FIBMKEEFDEG(APLBGFGJNCA PPFEHOPFFPG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal static class HDGEBAKCHEN
{
	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x6FB3410", Offset = "0x6FB2410", VA = "0x186FB3410")]
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
		[Cpp2IlInjected.Address(RVA = "0xD78E70", Offset = "0xD77E70", VA = "0x180D78E70", Slot = "7")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x6FB4190", Offset = "0x6FB3190", VA = "0x186FB4190", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public Vector3 DMKBNHANJAP
	{
		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x6FB5BD0", Offset = "0x6FB4BD0", VA = "0x186FB5BD0", Slot = "9")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public float BOLEMMHMCAB
	{
		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x8D09E0", Offset = "0x8CF9E0", VA = "0x1808D09E0", Slot = "10")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x6FB3810", Offset = "0x6FB2810", VA = "0x186FB3810")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public float JCPNADANAGB
	{
		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x8D0AF0", Offset = "0x8CFAF0", VA = "0x1808D0AF0", Slot = "11")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x6FB35E0", Offset = "0x6FB25E0", VA = "0x186FB35E0", Slot = "12")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public Vector3 OGIAMCOBEDN
	{
		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x6FB3BA0", Offset = "0x6FB2BA0", VA = "0x186FB3BA0", Slot = "13")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public Quaternion ILIHBKBCLNO
	{
		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x6FB4010", Offset = "0x6FB3010", VA = "0x186FB4010", Slot = "14")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	private Rigidbody IIPBAHLFLID
	{
		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x6FB5D70", Offset = "0x6FB4D70", VA = "0x186FB5D70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002A")]
	public event HJNBIKAPNHI DJBLLAAKELC
	{
		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x6FB3540", Offset = "0x6FB2540", VA = "0x186FB3540", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x6FB5CD0", Offset = "0x6FB4CD0", VA = "0x186FB5CD0", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x6FB5DC0", Offset = "0x6FB4DC0", VA = "0x186FB5DC0")]
	public IGKLCJDAICK(APLBGFGJNCA HOIOIPJLNDO, [In] MIAGEIJEICK FHNKDHIILBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x6FB4320", Offset = "0x6FB3320", VA = "0x186FB4320", Slot = "17")]
	public void JFEFDBPFKAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x6FB3920", Offset = "0x6FB2920", VA = "0x186FB3920", Slot = "16")]
	public void BGIAMMFHOEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(RVA = "0x6FB4240", Offset = "0x6FB3240", VA = "0x186FB4240", Slot = "19")]
	public void GFNCMGKLDEI(Rigidbody IBPJGMDGDIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x6FB3E20", Offset = "0x6FB2E20", VA = "0x186FB3E20", Slot = "20")]
	public void EBGHPNDPMOJ(Rigidbody IBPJGMDGDIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x6FB5A20", Offset = "0x6FB4A20", VA = "0x186FB5A20", Slot = "18")]
	public void MFCGGLFKNLK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x6FB44D0", Offset = "0x6FB34D0", VA = "0x186FB44D0", Slot = "21")]
	public void KAAHHJDKNAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x6FB4190", Offset = "0x6FB3190", VA = "0x186FB4190")]
	private void KMEPLGFOBDL(Vector3 CBAEIEAPLIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x6FB3D30", Offset = "0x6FB2D30", VA = "0x186FB3D30")]
	[Obsolete("This method is dangerous - the unity rigidbody is updated in a deferred manner and this world position may be stale")]
	private Vector3 DMJNEEKPOKM()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x6FB3810", Offset = "0x6FB2810", VA = "0x186FB3810")]
	private void BONKGINCFCF(float CBAEIEAPLIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x6FB35E0", Offset = "0x6FB25E0", VA = "0x186FB35E0")]
	private void ACAICLFONDI(float CBAEIEAPLIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x6FB3A00", Offset = "0x6FB2A00", VA = "0x186FB3A00")]
	private Vector3 BLLOCEOCBFA()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x6FB4970", Offset = "0x6FB3970", VA = "0x186FB4970", Slot = "15")]
	public void KDALBOFGHHC((Quaternion rot, Vector3 moments) GIALOAJHHIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x6FB3690", Offset = "0x6FB2690", VA = "0x186FB3690")]
	private Quaternion AOJKNOHGEGL()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x6FB5950", Offset = "0x6FB4950", VA = "0x186FB5950")]
	public void KKEHCEGECGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x6FB4BA0", Offset = "0x6FB3BA0", VA = "0x186FB4BA0", Slot = "4")]
	public (float, Vector3) KKEHCEGECGD(Rigidbody BEDHMMKOLOE)
	{
		return default((float, Vector3));
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal static class AJADGEOJBNM
{
	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x6FAEAC0", Offset = "0x6FADAC0", VA = "0x186FAEAC0")]
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
		[Cpp2IlInjected.Address(RVA = "0xF02480", Offset = "0xF01480", VA = "0x180F02480", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public JAFDOBAHKIN BDHIHHHPNOP
	{
		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x8DB860", Offset = "0x8DA860", VA = "0x1808DB860", Slot = "11")]
		get
		{
			return default(JAFDOBAHKIN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x6FB0940", Offset = "0x6FAF940", VA = "0x186FB0940")]
	public CLLEBNFLAEC(APLBGFGJNCA HOIOIPJLNDO, [In] MIAGEIJEICK FHNKDHIILBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x6FB05F0", Offset = "0x6FAF5F0", VA = "0x186FB05F0", Slot = "4")]
	public void NJNJFFLKLJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x6FB06C0", Offset = "0x6FAF6C0", VA = "0x186FB06C0")]
	private bool NLAFFKMPJGO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x6FB07A0", Offset = "0x6FAF7A0", VA = "0x186FB07A0", Slot = "5")]
	public void OFKLKDCJGJA(object OEDJKICDDGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x6FB0480", Offset = "0x6FAF480", VA = "0x186FB0480", Slot = "6")]
	public void HLGBADLIJGL(object OEDJKICDDGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x6FB04B0", Offset = "0x6FAF4B0", VA = "0x186FB04B0", Slot = "9")]
	public void NEOGDEAKAHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x6FB0360", Offset = "0x6FAF360", VA = "0x186FB0360")]
	private void EILCDOOMKEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x6FB07D0", Offset = "0x6FAF7D0", VA = "0x186FB07D0")]
	private void PLPOECPHELO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x6FB0760", Offset = "0x6FAF760", VA = "0x186FB0760", Slot = "8")]
	public void OAAGPJFOBLH(APLBGFGJNCA HOIOIPJLNDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x6FB0320", Offset = "0x6FAF320", VA = "0x186FB0320", Slot = "7")]
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
		[Cpp2IlInjected.Address(RVA = "0x6FAFBD0", Offset = "0x6FAEBD0", VA = "0x186FAFBD0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002B")]
	public event HJNBIKAPNHI OLEHIOMBLOL
	{
		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x6FAFC90", Offset = "0x6FAEC90", VA = "0x186FAFC90", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x6FAFD60", Offset = "0x6FAED60", VA = "0x186FAFD60", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x6FAFFE0", Offset = "0x6FAEFE0", VA = "0x186FAFFE0")]
	public BAJMODKBAKB(APLBGFGJNCA HOIOIPJLNDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x6FAFC80", Offset = "0x6FAEC80", VA = "0x186FAFC80", Slot = "7")]
	public void CNBBAJCBBGF(object OEDJKICDDGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x6FAFFD0", Offset = "0x6FAEFD0", VA = "0x186FAFFD0", Slot = "8")]
	public void NLNABJAHOLE(object OEDJKICDDGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x6FAFE80", Offset = "0x6FAEE80", VA = "0x186FAFE80", Slot = "9")]
	public void MEPPPGODBIL(object OEDJKICDDGA, bool OKDLNAIMGHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x6FAFF90", Offset = "0x6FAEF90", VA = "0x186FAFF90", Slot = "12")]
	public void NDFKGLEEOHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x6FAFE00", Offset = "0x6FAEE00", VA = "0x186FAFE00", Slot = "10")]
	public void GFNCMGKLDEI(Rigidbody NEPLMIMPLJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x6FAFD30", Offset = "0x6FAED30", VA = "0x186FAFD30", Slot = "11")]
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
		[Cpp2IlInjected.Address(RVA = "0x8687D0", Offset = "0x8677D0", VA = "0x1808687D0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public bool LNOIEOBPGOA
	{
		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x6FBD550", Offset = "0x6FBC550", VA = "0x186FBD550", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public bool HLOCEFHJFJC
	{
		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0xA7BEE0", Offset = "0xA7AEE0", VA = "0x180A7BEE0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002C")]
	public event HJNBIKAPNHI LLGAAAIHHIP
	{
		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x6FBDD70", Offset = "0x6FBCD70", VA = "0x186FBDD70", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x6FBDBA0", Offset = "0x6FBCBA0", VA = "0x186FBDBA0", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x6FBDE10", Offset = "0x6FBCE10", VA = "0x186FBDE10")]
	public LNNFDCCIFMH(APLBGFGJNCA HOIOIPJLNDO, [In] MIAGEIJEICK FHNKDHIILBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x6FBDC40", Offset = "0x6FBCC40", VA = "0x186FBDC40", Slot = "9")]
	public void NJNJFFLKLJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x6FBD570", Offset = "0x6FBC570", VA = "0x186FBD570", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x6FBD270", Offset = "0x6FBC270", VA = "0x186FBD270", Slot = "10")]
	public void AADHAIMFKPJ(APLBGFGJNCA HHMPHBNGMGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x6FBD3E0", Offset = "0x6FBC3E0", VA = "0x186FBD3E0", Slot = "11")]
	public void BKPHMNCBNLA(APLBGFGJNCA HHMPHBNGMGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x6FBDA30", Offset = "0x6FBCA30", VA = "0x186FBDA30")]
	private void KDMECLOHCAD(PhotonView OMCFGNDBOHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x6FBD8E0", Offset = "0x6FBC8E0", VA = "0x186FBD8E0")]
	private void JJHELPFFANK(GMBPJONDGEK EGFEGHKEKCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x6FBD670", Offset = "0x6FBC670", VA = "0x186FBD670")]
	private void FENILEDHILM(PhotonView JMAEBPCOJKF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
internal static class BCPIDNGFOKF
{
	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x6FB00D0", Offset = "0x6FAF0D0", VA = "0x186FB00D0")]
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
		[Cpp2IlInjected.Address(RVA = "0xCFF600", Offset = "0xCFE600", VA = "0x180CFF600", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x4549F20", Offset = "0x4548F20", VA = "0x184549F20", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public bool CHIDPLOENAH
	{
		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0xF4D450", Offset = "0xF4C450", VA = "0x180F4D450", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x4549F10", Offset = "0x4548F10", VA = "0x184549F10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public RigidbodyConstraints MNFAOBCAHEG
	{
		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x8687F0", Offset = "0x8677F0", VA = "0x1808687F0", Slot = "7")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x6FBFF60", Offset = "0x6FBEF60", VA = "0x186FBFF60", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x6FC0090", Offset = "0x6FBF090", VA = "0x186FC0090")]
	public NCLMHJPEJCM(APLBGFGJNCA HOIOIPJLNDO, [In] MIAGEIJEICK FHNKDHIILBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x6FBFF30", Offset = "0x6FBEF30", VA = "0x186FBFF30", Slot = "9")]
	public void GFNCMGKLDEI(Rigidbody IBPJGMDGDIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x6FBFF00", Offset = "0x6FBEF00", VA = "0x186FBFF00", Slot = "10")]
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
		[Cpp2IlInjected.Address(RVA = "0x8D0B70", Offset = "0x8CFB70", VA = "0x1808D0B70", Slot = "4")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x6FB1A90", Offset = "0x6FB0A90", VA = "0x186FB1A90", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public float OINHMCCHBFI
	{
		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x8D0B30", Offset = "0x8CFB30", VA = "0x1808D0B30", Slot = "6")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x6FB1B60", Offset = "0x6FB0B60", VA = "0x186FB1B60", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x6FB1C30", Offset = "0x6FB0C30", VA = "0x186FB1C30")]
	public FOPJHJJHBAC(APLBGFGJNCA HOIOIPJLNDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x6FB1A40", Offset = "0x6FB0A40", VA = "0x186FB1A40", Slot = "8")]
	public void GFNCMGKLDEI(Rigidbody IBPJGMDGDIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x6FB19A0", Offset = "0x6FB09A0", VA = "0x186FB19A0", Slot = "9")]
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
		[Cpp2IlInjected.Address(RVA = "0x6FB5D70", Offset = "0x6FB4D70", VA = "0x186FB5D70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	private bool GGPIKHKADAE
	{
		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x6FC1300", Offset = "0x6FC0300", VA = "0x186FC1300")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	private APLBGFGJNCA EGEBOODOFAP
	{
		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x6FC0E20", Offset = "0x6FBFE20", VA = "0x186FC0E20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	private bool OGKMLGMAMJM
	{
		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x6FC0B30", Offset = "0x6FBFB30", VA = "0x186FC0B30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002D")]
	public event HJNBIKAPNHI GFKOIMCPIOF
	{
		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x6FC11C0", Offset = "0x6FC01C0", VA = "0x186FC11C0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x6FC0B90", Offset = "0x6FBFB90", VA = "0x186FC0B90", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x6FC1450", Offset = "0x6FC0450", VA = "0x186FC1450")]
	public PMOPADIMCGC(APLBGFGJNCA HOIOIPJLNDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x6FC1320", Offset = "0x6FC0320", VA = "0x186FC1320", Slot = "6")]
	public void NJNJFFLKLJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x6FC0C30", Offset = "0x6FBFC30", VA = "0x186FC0C30", Slot = "8")]
	public void CLMOPEFPGKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x6FC09E0", Offset = "0x6FBF9E0", VA = "0x186FC09E0", Slot = "7")]
	public bool AGBCHGFAEEO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x6FC1260", Offset = "0x6FC0260", VA = "0x186FC1260", Slot = "9")]
	public void KPCLKJCNCKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x6FC13B0", Offset = "0x6FC03B0", VA = "0x186FC13B0", Slot = "11")]
	public void OGFNCOIHMFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x6FC1010", Offset = "0x6FC0010", VA = "0x186FC1010", Slot = "10")]
	public void GPHBGJPMKAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x6FC0C40", Offset = "0x6FBFC40", VA = "0x186FC0C40")]
	private bool EJIHMNEELBC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x6FC0E80", Offset = "0x6FBFE80", VA = "0x186FC0E80")]
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
		[Cpp2IlInjected.Address(RVA = "0x8687D0", Offset = "0x8677D0", VA = "0x1808687D0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x867E00", Offset = "0x866E00", VA = "0x180867E00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	private bool OGKMLGMAMJM
	{
		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x6FB2300", Offset = "0x6FB1300", VA = "0x186FB2300")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public bool BLNJFOECNGI
	{
		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0xF02480", Offset = "0xF01480", VA = "0x180F02480", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x6FC08D0", Offset = "0x6FBF8D0", VA = "0x186FC08D0")]
	public PBEKOKMAFHK(APLBGFGJNCA HOIOIPJLNDO, [In] MIAGEIJEICK FHNKDHIILBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x6FC0830", Offset = "0x6FBF830", VA = "0x186FC0830", Slot = "5")]
	public void NJNJFFLKLJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x6FC0320", Offset = "0x6FBF320", VA = "0x186FC0320", Slot = "7")]
	public void EBGLEEGCKPH(object OEDJKICDDGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x6FC0680", Offset = "0x6FBF680", VA = "0x186FC0680", Slot = "8")]
	public void JKEKIFFHNOK(object OEDJKICDDGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x6FC0350", Offset = "0x6FBF350", VA = "0x186FC0350", Slot = "9")]
	public void GBOHOMNEGGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x6FC0130", Offset = "0x6FBF130", VA = "0x186FC0130", Slot = "10")]
	public void AEHKHLMOJIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x6FC06B0", Offset = "0x6FBF6B0", VA = "0x186FC06B0", Slot = "11")]
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
		[Cpp2IlInjected.Address(RVA = "0x869520", Offset = "0x868520", VA = "0x180869520", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0x869500", Offset = "0x868500", VA = "0x180869500", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public GDLMMBKDOFD PDHMDHCJJAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(RVA = "0x868820", Offset = "0x867820", VA = "0x180868820", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0x868800", Offset = "0x867800", VA = "0x180868800", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public Vector3 PFPOLMCKFGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x6FC2DC0", Offset = "0x6FC1DC0", VA = "0x186FC2DC0", Slot = "8")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0x6FC2BF0", Offset = "0x6FC1BF0", VA = "0x186FC2BF0", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public Vector3 LPLJJCMDAJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0x6FC26C0", Offset = "0x6FC16C0", VA = "0x186FC26C0", Slot = "10")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0x6FC39B0", Offset = "0x6FC29B0", VA = "0x186FC39B0", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public Vector3 MGBDEJCEECD
	{
		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0x6FC39E0", Offset = "0x6FC29E0", VA = "0x186FC39E0", Slot = "12")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(RVA = "0x6FC2F20", Offset = "0x6FC1F20", VA = "0x186FC2F20", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public Vector3 GGAIONLLBJJ
	{
		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(RVA = "0x6FC2FE0", Offset = "0x6FC1FE0", VA = "0x186FC2FE0", Slot = "14")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x6FC1C20", Offset = "0x6FC0C20", VA = "0x186FC1C20", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public float KHBCBMICPIE
	{
		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0x8D0A50", Offset = "0x8CFA50", VA = "0x1808D0A50", Slot = "16")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0x6FC2CB0", Offset = "0x6FC1CB0", VA = "0x186FC2CB0", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public bool HMPBHMHCEBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x18CF360", Offset = "0x18CE360", VA = "0x1818CF360", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	private BNCMPGAJGPD KHAJIAPPDOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0x67F5AE0", Offset = "0x67F4AE0", VA = "0x1867F5AE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	private bool GGPIKHKADAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0x6FC3990", Offset = "0x6FC2990", VA = "0x186FC3990")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x6FC4A90", Offset = "0x6FC3A90", VA = "0x186FC4A90")]
	public PPKOBGEMEEM(APLBGFGJNCA HOIOIPJLNDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x6FC1B10", Offset = "0x6FC0B10", VA = "0x186FC1B10", Slot = "19")]
	public void NJNJFFLKLJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x6FC1BC0", Offset = "0x6FC0BC0", VA = "0x186FC1BC0", Slot = "36")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x6FC1E30", Offset = "0x6FC0E30", VA = "0x186FC1E30", Slot = "28")]
	public void GFNCMGKLDEI(Rigidbody IBPJGMDGDIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0xD3C790", Offset = "0xD3B790", VA = "0x180D3C790", Slot = "20")]
	public void NKHPKHMPMFD(object OEDJKICDDGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0xD3EB00", Offset = "0xD3DB00", VA = "0x180D3EB00", Slot = "30")]
	public void FGBCFIADCKO(object OEDJKICDDGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x6FC1C50", Offset = "0x6FC0C50", VA = "0x186FC1C50", Slot = "35")]
	public Vector3 FHOLLECDNPL(Vector3 GAIBCOAKDKC)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(RVA = "0x6FC1F60", Offset = "0x6FC0F60", VA = "0x186FC1F60", Slot = "34")]
	public Vector3 GIBOAKBIOBF(Vector3 JPHCCCIGOIO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0x6FC1B10", Offset = "0x6FC0B10", VA = "0x186FC1B10", Slot = "27")]
	public void DNCLFMGGGJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(RVA = "0x6FC1870", Offset = "0x6FC0870", VA = "0x186FC1870", Slot = "25")]
	public void DANBDBPOFDB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(RVA = "0x6FC27E0", Offset = "0x6FC17E0", VA = "0x186FC27E0", Slot = "24")]
	public void HOBKCMKFCLE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(RVA = "0x6FC18D0", Offset = "0x6FC08D0", VA = "0x186FC18D0", Slot = "33")]
	public void DEBGMMCHMJM(Vector3 JLAGCBDIOCE, Vector3 EDDEDOBFGPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(RVA = "0x6FC4080", Offset = "0x6FC3080", VA = "0x186FC4080", Slot = "32")]
	public void OFGCKBHIDPB(Vector3 OBEPKPEDLHP, Vector3 ABBPNJFJIFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x6FC4750", Offset = "0x6FC3750", VA = "0x186FC4750", Slot = "31")]
	public void PBEKBHIAIFL(Vector3 IJLKCHGFNBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x6FC40E0", Offset = "0x6FC30E0", VA = "0x186FC40E0", Slot = "22")]
	public void OHMJEBOOCPL(IFHGOPCKPNL JGPGGDILHJP, Vector3 FOFCEMPLBMF, float PMHFDGEEHMA, float CKOJHMCFDFN = 8f, float DAPEKAPEIGC = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x6FC2960", Offset = "0x6FC1960", VA = "0x186FC2960", Slot = "21")]
	public void IAAPNEJDAPI(NDHCMAFIHCP DMCPDILGENE, Vector3 CCIKDGBKHJI, float PFIFJDPLMHF = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x6FC35A0", Offset = "0x6FC25A0", VA = "0x186FC35A0", Slot = "23")]
	[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
	public void JNLCOADNGGC(NDHCMAFIHCP DMCPDILGENE, Vector3 ADNGPFKNGFI, float NBNJNGGMAEO = 7f, float JPGDHDCNCHB = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0xE43CB0", Offset = "0xE42CB0", VA = "0x180E43CB0")]
	private static void DBKLNBIHJCD(Vector3 EFBILKIFBJD, Vector3 FFJHDFACBIE, [Out] Vector3 JEJOKJIPMCH, [Out] Vector3 MDEJIFBEFLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x6FC14E0", Offset = "0x6FC04E0", VA = "0x186FC14E0", Slot = "29")]
	public Vector3 AEKAOILCHOO(Vector3 EFBILKIFBJD)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x6FC15C0", Offset = "0x6FC05C0", VA = "0x186FC15C0", Slot = "26")]
	public void BFJGNAHHNLH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x6FC2CB0", Offset = "0x6FC1CB0", VA = "0x186FC2CB0")]
	private void PDAIEKECKEF(float CBAEIEAPLIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x6FC48F0", Offset = "0x6FC38F0", VA = "0x186FC48F0")]
	private void PNAIHGPFHLH(Vector3 CCIKDGBKHJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x6FC1750", Offset = "0x6FC0750", VA = "0x186FC1750")]
	private Vector3 CELJBILIEHJ()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x6FC3B40", Offset = "0x6FC2B40", VA = "0x186FC3B40")]
	private void MMNBDLLGIGF(Vector3 JPHCCCIGOIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x6FC2840", Offset = "0x6FC1840", VA = "0x186FC2840")]
	private Vector3 HOCEDEBJEEI()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x6FC3110", Offset = "0x6FC2110", VA = "0x186FC3110")]
	private void JMINCOBPNIE(Vector3 CBAEIEAPLIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x6FC2120", Offset = "0x6FC1120", VA = "0x186FC2120")]
	private void GIFJLFPNFDG(Vector3 JPHCCCIGOIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x6FC3FD0", Offset = "0x6FC2FD0", VA = "0x186FC3FD0")]
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
