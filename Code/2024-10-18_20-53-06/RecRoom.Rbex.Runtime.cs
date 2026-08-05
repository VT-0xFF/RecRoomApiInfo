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
	public class LogRegistrationIndex : HLBHPGBFEKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x745A210", Offset = "0x7459610", VA = "0x18745A210", Slot = "4")]
		public override void MHJHNBDIMHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x8D39D0", Offset = "0x8D2DD0", VA = "0x1808D39D0")]
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
	public class _AssemblyIndex : PPJBMGKOMFN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private int[] localIndices0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private PKJBAPOINDL bitset0;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override string[] ServiceCategories
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x8AD890", Offset = "0x8ACC90", VA = "0x1808AD890", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x197D010", Offset = "0x197C410", VA = "0x18197D010", Slot = "5")]
		public override void CJONANIIMOP(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7465A20", Offset = "0x7464E20", VA = "0x187465A20")]
		private void FHJEABGIEGC(DCLDPENAHIJ registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x74659C0", Offset = "0x7464DC0", VA = "0x1874659C0", Slot = "6")]
		public override void AHJCDOHADEI(DCLDPENAHIJ registry, [In] NBLNAJMJFFC filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7465D30", Offset = "0x7465130", VA = "0x187465D30")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[DisallowMultipleComponent]
	public sealed class RigidbodyEx : MonoBehaviour, AKFJEGODPDH
	{
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private static readonly FLILHMOBPPM LLDKJFHDMHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private bool FMJGCOHOBHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private GNENMCIDPEM JJICPFNLBJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		[SerializeField]
		[MDLMPHLONML(OPJKPNFINLK.Self, false, false, false)]
		private Rigidbody unityRigidbody;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[SerializeField]
		[MDLMPHLONML(OPJKPNFINLK.SelfAndParent, true, false, false)]
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
		[FormerlySerializedAs("forceNoInterpolation")]
		[SerializeField]
		private LGMGBDCHIJJ physicsInterpolation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		[SerializeField]
		[Tooltip("If checked, this object's Unity Rigidbody will not be stripped when parenting the object to another RigidbodyEx. Only check this on objects that have a Unity Rigidbody by default and who need access to Unity physics events like OnTriggerEnter, OnCollisionEnter, etc. This is sometimes set via script instead of this flag.")]
		private bool keepUnityRigidbodyWhileParented;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5D")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		[Tooltip("If the RigidbodyEx has a parent that is being destroyed, this flag allows this RigidbodyEx to keep the parent set. The default behavior is thatthe parent property is set to null, resetting/clearing the existing parent when it is being destroyed.")]
		[SerializeField]
		private bool keepParentOnParentDestroy;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5E")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		[SerializeField]
		[HideInInspector]
		private bool hasUnityRigidbodyByDefault;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		internal GNENMCIDPEM MJFPMHLONAL
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x74615E0", Offset = "0x74609E0", VA = "0x1874615E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private GNENMCIDPEM LNDNJOKNOLA
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x8A89D0", Offset = "0x8A7DD0", VA = "0x1808A89D0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public int JLNMICMFDCK
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x7462ED0", Offset = "0x74622D0", VA = "0x187462ED0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public RigidbodyEx NEHGLHANBHO
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x7463230", Offset = "0x7462630", VA = "0x187463230")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public RigidbodyEx PAGLAEHKACJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x7463170", Offset = "0x7462570", VA = "0x187463170")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public RigidbodyEx DEDHJMDEEIE
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x7463E30", Offset = "0x7463230", VA = "0x187463E30")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x7465330", Offset = "0x7464730", VA = "0x187465330")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public Transform LBNFFJNEDNA
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x8D2B40", Offset = "0x8D1F40", VA = "0x1808D2B40", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public Transform BAFDECEPINN
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x8D2B40", Offset = "0x8D1F40", VA = "0x1808D2B40", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public MLNLAOAECFA CPPBBBPHILE
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x7462F30", Offset = "0x7462330", VA = "0x187462F30")]
			get
			{
				return default(MLNLAOAECFA);
			}
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x7464AE0", Offset = "0x7463EE0", VA = "0x187464AE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool DAGLDKDIDPH
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x7463540", Offset = "0x7462940", VA = "0x187463540")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool PNIHJIBCNFL
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x7463050", Offset = "0x7462450", VA = "0x187463050")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public OPFMAOOBLLA LGKPJBOBGMI
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x7463480", Offset = "0x7462880", VA = "0x187463480")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x7464CA0", Offset = "0x74640A0", VA = "0x187464CA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public PAFPNLLDLFP DLCPBKKGFLB
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x7463420", Offset = "0x7462820", VA = "0x187463420")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x7464C30", Offset = "0x7464030", VA = "0x187464C30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public bool FMHHHMCOOIN
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x7463370", Offset = "0x7462770", VA = "0x187463370")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public Rigidbody KIKAKLALKIE
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x74633D0", Offset = "0x74627D0", VA = "0x1874633D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool HCNFBODKBFP
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x74630B0", Offset = "0x74624B0", VA = "0x1874630B0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x7464B50", Offset = "0x7463F50", VA = "0x187464B50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool PDIJHFMIAEI
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x7122900", Offset = "0x7121D00", VA = "0x187122900", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public float IPFNNAPKOMK
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x7463DD0", Offset = "0x74631D0", VA = "0x187463DD0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public float OEDOLBEBPAL
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x7463D70", Offset = "0x7463170", VA = "0x187463D70")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x74652C0", Offset = "0x74646C0", VA = "0x1874652C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public float MDKLFLDLIGL
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x74637A0", Offset = "0x7462BA0", VA = "0x1874637A0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x7464F40", Offset = "0x7464340", VA = "0x187464F40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public float IJEGMGKOCME
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x74635A0", Offset = "0x74629A0", VA = "0x1874635A0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x7464D10", Offset = "0x7464110", VA = "0x187464D10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public bool DPPCADMPFNK
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x7464380", Offset = "0x7463780", VA = "0x187464380")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x7465870", Offset = "0x7464C70", VA = "0x187465870")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public Vector3 EELMIDPBNNF
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x7463B50", Offset = "0x7462F50", VA = "0x187463B50")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x7465090", Offset = "0x7464490", VA = "0x187465090")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public Vector3 CMGIJLBALNN
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x74644C0", Offset = "0x74638C0", VA = "0x1874644C0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public CollisionDetectionMode DAJJEEECJGD
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x74636E0", Offset = "0x7462AE0", VA = "0x1874636E0")]
			get
			{
				return default(CollisionDetectionMode);
			}
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x7464E60", Offset = "0x7464260", VA = "0x187464E60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public float MGCHCNEGFHE
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x7463110", Offset = "0x7462510", VA = "0x187463110")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x7464BC0", Offset = "0x7463FC0", VA = "0x187464BC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public RigidbodyConstraints APGEKBNINPE
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x7463740", Offset = "0x7462B40", VA = "0x187463740")]
			get
			{
				return default(RigidbodyConstraints);
			}
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x7464ED0", Offset = "0x74642D0", VA = "0x187464ED0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public Vector3 BCPJOGOFGPN
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x7463EF0", Offset = "0x74632F0", VA = "0x187463EF0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public Vector3 LJLILEIEGCF
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x7463EF0", Offset = "0x74632F0", VA = "0x187463EF0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x7465650", Offset = "0x7464A50", VA = "0x187465650")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public float ABBNOLDJHOI
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x7463C30", Offset = "0x7463030", VA = "0x187463C30")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x7465170", Offset = "0x7464570", VA = "0x187465170")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public float BPEKFLDJBAB
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x7464320", Offset = "0x7463720", VA = "0x187464320")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x7465800", Offset = "0x7464C00", VA = "0x187465800")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public Quaternion NIHHJHDBNGP
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x7463FD0", Offset = "0x74633D0", VA = "0x187463FD0")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x74653D0", Offset = "0x74647D0", VA = "0x1874653D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public Quaternion FGNLKIGDBJL
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x7464250", Offset = "0x7463650", VA = "0x187464250")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x7465730", Offset = "0x7464B30", VA = "0x187465730")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public Vector3 KCKBBEGNBLL
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x74640A0", Offset = "0x74634A0", VA = "0x1874640A0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x74654A0", Offset = "0x74648A0", VA = "0x1874654A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public Quaternion DKHEJMEAKBP
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x7464180", Offset = "0x7463580", VA = "0x187464180")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x7465580", Offset = "0x7464980", VA = "0x187465580")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public Vector3 DLNLPMKHKIC
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x74643E0", Offset = "0x74637E0", VA = "0x1874643E0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x74658E0", Offset = "0x7464CE0", VA = "0x1874658E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public Vector3 AHELNOLPMIB
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x7463C90", Offset = "0x7463090", VA = "0x187463C90")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x74651E0", Offset = "0x74645E0", VA = "0x1874651E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public Vector3 BGJOJHOMGKA
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x7463600", Offset = "0x7462A00", VA = "0x187463600")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x7464D80", Offset = "0x7464180", VA = "0x187464D80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public Vector3 GCFMFJNALIM
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x7463A70", Offset = "0x7462E70", VA = "0x187463A70")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x7464FB0", Offset = "0x74643B0", VA = "0x187464FB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Vector3 GDOAKHFJMIE
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x7463930", Offset = "0x7462D30", VA = "0x187463930")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public Quaternion MOHECIHCDGC
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x7463860", Offset = "0x7462C60", VA = "0x187463860")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public Vector3 BKAFNHNFHMN
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x7464680", Offset = "0x7463A80", VA = "0x187464680")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public Vector3 AEJPLHAPCDC
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x74645A0", Offset = "0x74639A0", VA = "0x1874645A0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public bool HHDMKGALEHG
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x7463A10", Offset = "0x7462E10", VA = "0x187463A10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public bool GBGJLIKBJAA
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x74634E0", Offset = "0x74628E0", VA = "0x1874634E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool MFOAFDNOLHL
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x7462FF0", Offset = "0x74623F0", VA = "0x187462FF0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool HMHOAFAJDHN
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x7462F90", Offset = "0x7462390", VA = "0x187462F90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public bool INBJHNLAIFN
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x7462E70", Offset = "0x7462270", VA = "0x187462E70")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public bool FNKFBKKDPCH
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x7463800", Offset = "0x7462C00", VA = "0x187463800")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public bool BCAMLDHBAPM
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x1C18370", Offset = "0x1C17770", VA = "0x181C18370")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event JGNAGMIJHCB FKAPHBKKPKA
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x7462D90", Offset = "0x7462190", VA = "0x187462D90")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x7464A00", Offset = "0x7463E00", VA = "0x187464A00")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event EIBFAGEEMAF IFCEEFDAHEF
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x7462B00", Offset = "0x7461F00", VA = "0x187462B00")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x7464760", Offset = "0x7463B60", VA = "0x187464760")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event EIBFAGEEMAF AEIMJFGGBMI
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x7462B60", Offset = "0x7461F60", VA = "0x187462B60")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x74647D0", Offset = "0x7463BD0", VA = "0x1874647D0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event EIBFAGEEMAF LFINLFDFJPP
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x7462CB0", Offset = "0x74620B0", VA = "0x187462CB0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x7464920", Offset = "0x7463D20", VA = "0x187464920")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action<JHPLKFFCHDF, JHPLKFFCHDF> LAAJLCKFOHC
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x7462C40", Offset = "0x7462040", VA = "0x187462C40")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x74648B0", Offset = "0x7463CB0", VA = "0x1874648B0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event EIBFAGEEMAF BPEONMCDJJB
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x7462D20", Offset = "0x7462120", VA = "0x187462D20")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x7464990", Offset = "0x7463D90", VA = "0x187464990")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event EIBFAGEEMAF BHBKMDGAJDM
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x7462E00", Offset = "0x7462200", VA = "0x187462E00")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x7464A70", Offset = "0x7463E70", VA = "0x187464A70")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event EIBFAGEEMAF CEHKLBHNDEK
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x7462BD0", Offset = "0x7461FD0", VA = "0x187462BD0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x7464840", Offset = "0x7463C40", VA = "0x187464840")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8A8A00", Offset = "0x8A7E00", VA = "0x1808A8A00", Slot = "8")]
		private void LEGPNFLPPEF(GNENMCIDPEM JPNNGBEFPIE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7461240", Offset = "0x7460640", VA = "0x187461240")]
		internal void DHKPMCJMBCI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7462830", Offset = "0x7461C30", VA = "0x187462830")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		public void TestOverrideUnityRigidbody(Rigidbody MGNFHHHINDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x7461330", Offset = "0x7460730", VA = "0x187461330")]
		public AKFJEGODPDH GetChild(int HAJICDLBEKC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x7462500", Offset = "0x7461900", VA = "0x187462500")]
		public void SetInertiaTensor((Quaternion rot, Vector3 moments) IFAMPJEONCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x7461050", Offset = "0x7460450", VA = "0x187461050")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x74615E0", Offset = "0x74609E0", VA = "0x1874615E0")]
		private GNENMCIDPEM IFEGNLFEKMJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x7461690", Offset = "0x7460A90", VA = "0x187461690")]
		private void IPNPHEKPPLJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x7461CD0", Offset = "0x74610D0", VA = "0x187461CD0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x7461240", Offset = "0x7460640", VA = "0x187461240")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x7461C70", Offset = "0x7461070", VA = "0x187461C70")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x7461D30", Offset = "0x7461130", VA = "0x187461D30")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x74606A0", Offset = "0x745FAA0", VA = "0x1874606A0")]
		public void AddDoNotResetVelocityOnOwnershipChangeOverride(object ABHFNNFMPHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x7461D90", Offset = "0x7461190", VA = "0x187461D90")]
		public void RemoveDoNotResetVelocityOnOwnershipChangeOverride(object ABHFNNFMPHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x74612D0", Offset = "0x74606D0", VA = "0x1874612D0")]
		public void DisableCachedInertialPropertyOverride()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x7461C10", Offset = "0x7461010", VA = "0x187461C10")]
		public void MarkCachedInertialParametersDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x7462660", Offset = "0x7461A60", VA = "0x187462660")]
		public void SetParent(RigidbodyEx EEPLCHCGAIN, bool LCNIJLOJAGJ = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x74620A0", Offset = "0x74614A0", VA = "0x1874620A0")]
		public void ResetLocalCenterOfMassToPrefabDefault()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x74618A0", Offset = "0x7460CA0", VA = "0x1874618A0")]
		public bool IsRigidbodyAncestor(RigidbodyEx LJNHDGKFAKF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x74619A0", Offset = "0x7460DA0", VA = "0x1874619A0")]
		public bool IsRigidbodyDescendant(RigidbodyEx CACEHMAIDDH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x7460910", Offset = "0x745FD10", VA = "0x187460910")]
		public void AddInterpolationRestriction(object ABHFNNFMPHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x7461E00", Offset = "0x7461200", VA = "0x187461E00")]
		public void RemoveInterpolationRestriction(object ABHFNNFMPHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x7460980", Offset = "0x745FD80", VA = "0x187460980")]
		public void AddKinematic(object ABHFNNFMPHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x7461E70", Offset = "0x7461270", VA = "0x187461E70")]
		public void RemoveKinematic(object ABHFNNFMPHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x74625E0", Offset = "0x74619E0", VA = "0x1874625E0")]
		public void SetKinematic(object ABHFNNFMPHA, bool PKMIKOAMPIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x7462400", Offset = "0x7461800", VA = "0x187462400")]
		public void SetDiscontinuousPositionAndRotation(Vector3 MFPJNNFLIFP, Quaternion LLJELCFPHCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x7462300", Offset = "0x7461700", VA = "0x187462300")]
		public void SetDiscontinuousLocalPositionAndLocalRotation(Vector3 IALALBHIOOH, Quaternion BDCEABKAEDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x74614D0", Offset = "0x74608D0", VA = "0x1874614D0")]
		public Vector3 GetConstrainedVelocity(Vector3 DLNLPMKHKIC)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x74613C0", Offset = "0x74607C0", VA = "0x1874613C0")]
		public Vector3 GetConstrainedAngularVelocity(Vector3 BGJOJHOMGKA)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x7460820", Offset = "0x745FC20", VA = "0x187460820")]
		public void AddForce(Vector3 MALABKOONDB, ForceMode BFEPKKCNFOD = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x7460710", Offset = "0x745FB10", VA = "0x187460710")]
		public void AddForceAtPosition(Vector3 MALABKOONDB, Vector3 CLHMEGFDOKF, ForceMode BFEPKKCNFOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x7460B50", Offset = "0x745FF50", VA = "0x187460B50")]
		public void AddTorque(Vector3 IHEPDJJOFIK, ForceMode BFEPKKCNFOD = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x74609F0", Offset = "0x745FDF0", VA = "0x1874609F0")]
		public void AddRelativeTorque(Vector3 IHEPDJJOFIK, ForceMode BFEPKKCNFOD = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x7462900", Offset = "0x7461D00", VA = "0x187462900")]
		public Vector3 WorldToLocalVelocity(Vector3 LFFEGBGDOPO)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x7461B00", Offset = "0x7460F00", VA = "0x187461B00")]
		public Vector3 LocalToWorldVelocity(Vector3 AHELNOLPMIB)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x74611E0", Offset = "0x74605E0", VA = "0x1874611E0")]
		public void ClearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x7461180", Offset = "0x7460580", VA = "0x187461180")]
		public void ClearUnityRigidbodyVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x7461120", Offset = "0x7460520", VA = "0x187461120")]
		public void ClearLinearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x74610C0", Offset = "0x74604C0", VA = "0x1874610C0")]
		public void ClearAngularVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x7462200", Offset = "0x7461600", VA = "0x187462200")]
		public void ResetVelocityWorldSpace(Vector3 FICPNOACCPA, Vector3 MBHKBNFIGNE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x7462100", Offset = "0x7461500", VA = "0x187462100")]
		public void ResetVelocityLocalSpace(Vector3 KFINDPIHPIF, Vector3 GCFMFJNALIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x7461FC0", Offset = "0x74613C0", VA = "0x187461FC0")]
		public void ResetLinearVelocityLocalSpace(Vector3 KFINDPIHPIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x7462790", Offset = "0x7461B90", VA = "0x187462790")]
		public bool SweepTest(Vector3 PAAGAJJEHGO, [Out] RaycastHit NKGBAALLKCD, float NHDEHMAPALH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x7461AA0", Offset = "0x7460EA0", VA = "0x187461AA0")]
		public bool IsSleeping()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x7462730", Offset = "0x7461B30", VA = "0x187462730")]
		public void Sleep()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x74628A0", Offset = "0x7461CA0", VA = "0x1874628A0")]
		public void WakeUp()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x7460AE0", Offset = "0x745FEE0", VA = "0x187460AE0")]
		public void AddShouldHaveUnityRigidbodyToken(object ABHFNNFMPHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x7461EE0", Offset = "0x74612E0", VA = "0x187461EE0")]
		public void RemoveShouldHaveUnityRigidbodyToken(object ABHFNNFMPHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x7460EE0", Offset = "0x74602E0", VA = "0x187460EE0")]
		public void ApplyForceVelocityChange(ECHIOPDOMDO IONCIEEBOBO, Vector3 JOGLJMPKPKH, float PPDEONJIIMA, float OFOGFBIIGGI = 8f, float BJMNFCJBKKE = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x7460DE0", Offset = "0x74601E0", VA = "0x187460DE0")]
		public void ApplyAngularVelocityChange(ECJJLAKNLID KOCJMOOKFFH, Vector3 BBIPOCPEDJM, float JLDDDBDKMNI = float.PositiveInfinity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x7460FA0", Offset = "0x74603A0", VA = "0x187460FA0")]
		[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
		public void ApplyTorqueAngularVelocityChangeDeprecated(ECJJLAKNLID KOCJMOOKFFH, Vector3 MDJOMEFJFHD, float BBBGCFNLFEE = 7f, float LDHDIPAMOEN = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x7460D10", Offset = "0x7460110", VA = "0x187460D10")]
		public bool AllowedScaleChange(float KHDOIBPNKOB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x7460C40", Offset = "0x7460040", VA = "0x187460C40")]
		public void AddWorldSpaceVelocityInHierarchyParentOverride(RigidbodyEx DFKIPILFANJ, object ABHFNNFMPHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x7461F50", Offset = "0x7461350", VA = "0x187461F50")]
		public void RemoveWorldSpaceVelocityInHierarchyParentOverride(object ABHFNNFMPHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x7462A90", Offset = "0x7461E90", VA = "0x187462A90")]
		public RigidbodyEx()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0xCA27F0", Offset = "0xCA1BF0", VA = "0x180CA27F0", Slot = "4")]
		private GameObject ODIFFGPIFHB()
		{
			return null;
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x8D2B40", Offset = "0x8D1F40", VA = "0x1808D2B40", Slot = "5")]
		private Transform JDOICLIHCFD()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
internal static class OHPKFFKJDOG
{
	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x7460250", Offset = "0x745F650", VA = "0x187460250")]
	public static GNENMCIDPEM MJFPMHLONAL(this RigidbodyEx GJHPLGMALIK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[MEMFFHBLAMF(typeof(ODOBDEHJAPK), new string[] { })]
public class PMJKAABAIIG : ODOBDEHJAPK, PCLMMJFGOJL
{
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private static readonly FLILHMOBPPM APPINHJJCPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private PJAAGGJLMPG JAEGMFGHGGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private NCHLPOPKPEO BLDEOEOIGBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private CJFAMILEGNO IPMOENJCOCL;

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public NCHLPOPKPEO CJLPCPGMLEN
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x8A89C0", Offset = "0x8A7DC0", VA = "0x1808A89C0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public CJFAMILEGNO PCKMFOGMEHC
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x8A89D0", Offset = "0x8A7DD0", VA = "0x1808A89D0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x7460380", Offset = "0x745F780", VA = "0x187460380", Slot = "7")]
	public void InitReferences(MLIFIICJDOD JGADEBKHJGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x7460410", Offset = "0x745F810", VA = "0x187460410", Slot = "6")]
	public GNENMCIDPEM LAHOIJPCLLJ(RigidbodyEx GJHPLGMALIK, HBBDMOFMLCI AIKOCCMKKAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
	public PMJKAABAIIG()
	{
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class PhysicsManager : SingletonMonoBehaviour<PhysicsManager>
	{
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static LDNMACGBDLI UpdateAfterFixedUpdateRan;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private int JAKOKMNGPPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private int DDAICPEEEBF;

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x7460520", Offset = "0x745F920", VA = "0x187460520")]
		protected void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x7460560", Offset = "0x745F960", VA = "0x187460560")]
		protected void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x7460540", Offset = "0x745F940", VA = "0x187460540")]
		protected void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x8AA270", Offset = "0x8A9670", VA = "0x1808AA270")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsNotYetUpdated([Optional] string MOKGCFCFCPE, [Optional] UnityEngine.Object OMHMFLHBNDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x8AA270", Offset = "0x8A9670", VA = "0x1808AA270")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsAlreadyUpdated([Optional] string MOKGCFCFCPE, [Optional] UnityEngine.Object OMHMFLHBNDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x7460650", Offset = "0x745FA50", VA = "0x187460650")]
		public PhysicsManager()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class HEBDICJEMII
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private class LBMHBNNCCOP : OPFMAOOBLLA, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x8AA270", Offset = "0x8A9670", VA = "0x1808AA270", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x8B99E0", Offset = "0x8B8DE0", VA = "0x1808B99E0", Slot = "4")]
		public Vector3 PGELIKFKMGC()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x8B99E0", Offset = "0x8B8DE0", VA = "0x1808B99E0", Slot = "5")]
		public Vector3 JBABKHBCFGJ()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
		public LBMHBNNCCOP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public static OPFMAOOBLLA ALFKAHCDFOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x7451C60", Offset = "0x7451060", VA = "0x187451C60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface CFBEDLKJPDI
{
	[Cpp2IlInjected.Token(Token = "0x17000037")]
	CollisionDetectionMode HBONCPHCCAF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OICKCJAMCMG();

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void OJDJMGJMOOG(bool HHDMKGALEHG);

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void MPCEJMPGENI(bool HHDMKGALEHG);

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void BMHAAMJPCLN(Rigidbody KLDNEBDEBMN);

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool CDGBDFLPKMM(Vector3 PAAGAJJEHGO, [Out] RaycastHit NKGBAALLKCD, float NHDEHMAPALH);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface AMNDOGIPNGK : IDisposable, HAMADHEGBGJ
{
	[Cpp2IlInjected.Token(Token = "0x17000038")]
	MLNLAOAECFA CPPBBBPHILE
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event Action<JHPLKFFCHDF, JHPLKFFCHDF> LAAJLCKFOHC;

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void OICKCJAMCMG();
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[AEODNGLJNOH(HNNAHENHILF.Application)]
public interface CJFAMILEGNO
{
	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	MALEKPJFBCF PDFHCHPLBBF(GNENMCIDPEM JPNNGBEFPIE);

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "1")]
	JAPLBFANHGD LDFDIMDKIML(GNENMCIDPEM JPNNGBEFPIE);

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "2")]
	DNLNOLOCGHB PIECNDDOACE(GNENMCIDPEM JPNNGBEFPIE);

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "3")]
	AKKOCMLEJGJ ENJNLMPGIDH(GNENMCIDPEM JPNNGBEFPIE);

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "4")]
	CJHDOGPCDKJ IKPJPBKKEIC(GNENMCIDPEM JPNNGBEFPIE);

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "5")]
	AMNDOGIPNGK HNKADIOCAAK(GNENMCIDPEM JPNNGBEFPIE);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "6")]
	NHBHBFNDACL PCIDPNGMBEH(GNENMCIDPEM JPNNGBEFPIE);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "7")]
	ICDBJMBBKCB ADLAMNAPBGL(GNENMCIDPEM JPNNGBEFPIE);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "8")]
	CFBEDLKJPDI LLNKHOMPGGL(GNENMCIDPEM JPNNGBEFPIE);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "9")]
	CIAKONMFMIM OHHKGBKJPOB(GNENMCIDPEM JPNNGBEFPIE);

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "10")]
	DAHLIOGLLCA HLNPGKDPIEA(GNENMCIDPEM JPNNGBEFPIE, [In] HBBDMOFMLCI AIKOCCMKKAE);

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "11")]
	JDCOHKKMABP FGBLGMBIIFM(GNENMCIDPEM JPNNGBEFPIE, [In] HBBDMOFMLCI AIKOCCMKKAE);

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "12")]
	IAFNLOGPHDM FNKEIJNCMOF(GNENMCIDPEM JPNNGBEFPIE, [In] HBBDMOFMLCI AIKOCCMKKAE);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "13")]
	FECOODOBHCB OCICENNAGEP(GNENMCIDPEM JPNNGBEFPIE, [In] HBBDMOFMLCI AIKOCCMKKAE);

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "14")]
	EGFCLOFMPEI JNPCPJGMPIG(GNENMCIDPEM JPNNGBEFPIE, [In] HBBDMOFMLCI AIKOCCMKKAE);

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "15")]
	GNENMCIDPEM LAHOIJPCLLJ(RigidbodyEx GJHPLGMALIK, HBBDMOFMLCI AIKOCCMKKAE, ODOBDEHJAPK BLMJILKGBHG);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface ICDBJMBBKCB
{
	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GOLMBOBCIAE(Vector3 MALABKOONDB, ForceMode BFEPKKCNFOD = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DMDNKPCMOML(Vector3 MALABKOONDB, Vector3 CLHMEGFDOKF, ForceMode BFEPKKCNFOD);

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LLJKEPGCFPF(Vector3 IHEPDJJOFIK, ForceMode BFEPKKCNFOD = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void OENFINJMCLJ(Vector3 IHEPDJJOFIK, ForceMode BFEPKKCNFOD = ForceMode.Force);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface CIAKONMFMIM
{
	[Cpp2IlInjected.Token(Token = "0x17000039")]
	bool JODBLCMDIOP
	{
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BMHAAMJPCLN(Rigidbody KLDNEBDEBMN);

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void GOPOMIDILEH(Rigidbody KLDNEBDEBMN);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface MALEKPJFBCF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	IReadOnlyList<GNENMCIDPEM> NIHHOEPBMGI
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	GNENMCIDPEM PAGLAEHKACJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	GNENMCIDPEM CNLABKPDMID
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(Slot = "21")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event EIBFAGEEMAF IFCEEFDAHEF;

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event EIBFAGEEMAF AEIMJFGGBMI;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event JGNAGMIJHCB PDDMGHPLGCE;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action NFAAMLDIMFJ;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event Action AMGKGMEFEPI;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	event Action<GNENMCIDPEM> MGHKLODBEAA;

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event Action<GNENMCIDPEM> HMLGHAEINDA;

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	event Action NHOJFFLKPJO;

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	event Action<GNENMCIDPEM> EJDHADNFOAF;

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void HGECDLHOFAC(GNENMCIDPEM LNNICEPGDAG, bool LCNIJLOJAGJ = false);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface DNLNOLOCGHB
{
	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	Vector3 LBGLBFFMPFG
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	Vector3 KLAEBFDLDLL
	{
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DGOGNNKLONK(GNENMCIDPEM DEDHJMDEEIE, object ABHFNNFMPHA);

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void MIGJIDHNDIP(object ABHFNNFMPHA);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface FECOODOBHCB
{
	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	Vector3 MJDCGLHPNEL
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	Vector3 NALPKDKIGKK
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	float CMPNNGPHAJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	float BICLGLJPJHG
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	Vector3 PJNENDEALGA
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	Quaternion DNCJEDDOJMO
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	event EIBFAGEEMAF AIJLPDKCNPD;

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void KKAKDEJIFDA((Quaternion rot, Vector3 moments) IFAMPJEONCG);

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void EGDBGLFOHBG();

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void BFCJABJNJNJ();

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void JKLECADOEME();

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void BMHAAMJPCLN(Rigidbody KLDNEBDEBMN);

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void GOPOMIDILEH(Rigidbody KLDNEBDEBMN);

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void HHLMEAPLHIF();
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface IAFNLOGPHDM
{
	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OICKCJAMCMG();

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NNHKBEFOLHD(object ABHFNNFMPHA);

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JMIFIJKGOFB(object ABHFNNFMPHA);

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void HFCLPMKMAOF(GNENMCIDPEM GJHPLGMALIK);

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void LNHCOLCLNEA(GNENMCIDPEM GJHPLGMALIK);

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void ICLONOGELBN();
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface NHBHBFNDACL
{
	[Cpp2IlInjected.Token(Token = "0x17000045")]
	bool OMKBNDMPAEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	event EIBFAGEEMAF BMHAGMABFJE;

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void MDOKJEKJEPB(object ABHFNNFMPHA);

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void NFNBHJKHGPF(object ABHFNNFMPHA);

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void COGFCLDDILJ(object ABHFNNFMPHA, bool PKMIKOAMPIA);

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void BMHAAMJPCLN(Rigidbody FLPMJAFBFIG);

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void GOPOMIDILEH(Rigidbody KLDNEBDEBMN);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface JDCOHKKMABP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000046")]
	bool DAGLDKDIDPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	bool PNIHJIBCNFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	event EIBFAGEEMAF LCICBLPNPKE;

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void OICKCJAMCMG();

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void MOFEPKJILNI(GNENMCIDPEM DEDHJMDEEIE);

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void EGPDKDMNMLI(GNENMCIDPEM DEDHJMDEEIE);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface EGFCLOFMPEI
{
	[Cpp2IlInjected.Token(Token = "0x17000048")]
	bool HCNFBODKBFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	bool ACDONNIKLPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	RigidbodyConstraints CCNGDIBBDAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void BMHAAMJPCLN(Rigidbody KLDNEBDEBMN);

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void GOPOMIDILEH(Rigidbody KLDNEBDEBMN);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface AKKOCMLEJGJ
{
	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	float GIIOJNIOBNG
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	float MKKCJHHNAOG
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void BMHAAMJPCLN(Rigidbody KLDNEBDEBMN);

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void GOPOMIDILEH(Rigidbody KLDNEBDEBMN);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface CJHDOGPCDKJ
{
	[Cpp2IlInjected.Token(Token = "0x14000016")]
	event EIBFAGEEMAF KCEGOHOIJLE;

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OICKCJAMCMG();

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool KCNDEMAKNNC();

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void OHMOBPDINJJ();

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void DLBLJMIMABA();

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void JBKDEAHBDKJ();

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void ENCEEBEJNHB();
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface DAHLIOGLLCA
{
	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	Rigidbody KIKAKLALKIE
	{
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	bool GIOGMNMBLBO
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OICKCJAMCMG();

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void HNNIKFOPAHB(object ABHFNNFMPHA);

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void LAJLCBGBEBF(object ABHFNNFMPHA);

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void GFONJABDCCI();
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface JAPLBFANHGD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	OPFMAOOBLLA LGKPJBOBGMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	PAFPNLLDLFP DLCPBKKGFLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	Vector3 LAGAIBFOEEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	Vector3 BHOHPOALPMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	Vector3 KNNCHNCILOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	Vector3 APBHOELFNPE
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	float MGCHCNEGFHE
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	bool FMHHHMCOOIN
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void OICKCJAMCMG();

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void PCPFADBGCFB(object ABHFNNFMPHA);

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void EFLEMJFNFOP(ECJJLAKNLID KOCJMOOKFFH, Vector3 BBIPOCPEDJM, float JLDDDBDKMNI = float.PositiveInfinity);

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void EGMKAAINCJN(ECHIOPDOMDO IONCIEEBOBO, Vector3 JOGLJMPKPKH, float PPDEONJIIMA, float OFOGFBIIGGI = 8f, float BJMNFCJBKKE = 1f);

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void ILEPDKIGMPO(ECJJLAKNLID KOCJMOOKFFH, Vector3 MDJOMEFJFHD, float BBBGCFNLFEE = 7f, float LDHDIPAMOEN = 1f);

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void CFNDDLJCEMO();

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void CADKCHJHLHI();

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void JLGHMDCLJFJ();

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void IJMNINGLFII();

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void BMHAAMJPCLN(Rigidbody KLDNEBDEBMN);

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(Slot = "25")]
	Vector3 IIPLLEMKFCG(Vector3 DLNLPMKHKIC);

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void ABCBDPCLGHM(object ABHFNNFMPHA);

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void MGOINFGFJOD(Vector3 PCALPEJHEDG);

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void FFAELKNMIGM(Vector3 KFINDPIHPIF, Vector3 GCFMFJNALIM);

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void DJLBKENEHMH(Vector3 FICPNOACCPA, Vector3 MBHKBNFIGNE);

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(Slot = "30")]
	Vector3 GIEDGGBOHPA(Vector3 AHELNOLPMIB);

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(Slot = "31")]
	Vector3 EIFFMIENBIO(Vector3 LFFEGBGDOPO);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[AEODNGLJNOH(HNNAHENHILF.Application)]
public interface NCHLPOPKPEO
{
	[Cpp2IlInjected.Token(Token = "0x17000057")]
	bool NIDBONJOPOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NDGLPPDPCCA(string MEDJAOOGFHP);

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DMPBMJDMKBJ(RigidbodyEx GJHPLGMALIK, Action HJOAJFDFEDM);

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(Slot = "3")]
	MIIBBEHCOHE OKPNFGBEIGM(int KHEJFJEICIH);

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void FJNPBIFBOOL(Vector3 CMGIJLBALNN, float DOAKIMCLKHN, Color KLMDPLMNJMP);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[AEODNGLJNOH(HNNAHENHILF.Application)]
public interface ODOBDEHJAPK
{
	[Cpp2IlInjected.Token(Token = "0x17000058")]
	NCHLPOPKPEO CJLPCPGMLEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	CJFAMILEGNO PCKMFOGMEHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(Slot = "2")]
	GNENMCIDPEM LAHOIJPCLLJ(RigidbodyEx GJHPLGMALIK, HBBDMOFMLCI AIKOCCMKKAE);
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class NLAMLALBDFJ : GNENMCIDPEM, IDisposable, GFNFKBMBBAB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	internal readonly ODOBDEHJAPK BLMJILKGBHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	internal MALEKPJFBCF HNGCDAAKGJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	internal IAFNLOGPHDM HNAOANNPGJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	internal JDCOHKKMABP PPMMDMNMOMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	internal JAPLBFANHGD DLNLPMKHKIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	internal DNLNOLOCGHB OFPNKMIDALG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	internal FECOODOBHCB NAELEKJGIAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	internal AKKOCMLEJGJ OBFEMCACKKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	internal CIAKONMFMIM HJLOEGOACHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	internal CJHDOGPCDKJ MMIDKJFOHKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	internal AMNDOGIPNGK AECGNCFDPNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	internal NHBHBFNDACL GDADAHAHNIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	internal ICDBJMBBKCB MALABKOONDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	internal EGFCLOFMPEI OKIMBDPACND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	internal DAHLIOGLLCA KLDNEBDEBMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	internal CFBEDLKJPDI PMONMLFNHKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	internal IDisposable FBLEMKBDGID;

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public AGLPGLMEACF DGDENOKALKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x8AA280", Offset = "0x8A9680", VA = "0x1808AA280", Slot = "22")]
		get
		{
			return default(AGLPGLMEACF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public AKFJEGODPDH EBCPMMAAAGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x8AFC70", Offset = "0x8AF070", VA = "0x1808AFC70", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x8AFCA0", Offset = "0x8AF0A0", VA = "0x1808AFCA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public GameObject HAIKDHHODMO
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x9B5880", Offset = "0x9B4C80", VA = "0x1809B5880", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x9B0D00", Offset = "0x9B0100", VA = "0x1809B0D00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public Transform BDJMNGJGEPI
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x8B2320", Offset = "0x8B1720", VA = "0x1808B2320", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x8B2360", Offset = "0x8B1760", VA = "0x1808B2360")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public Rigidbody KIKAKLALKIE
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x745F470", Offset = "0x745E870", VA = "0x18745F470", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public GNENMCIDPEM CNLABKPDMID
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x745C680", Offset = "0x745BA80", VA = "0x18745C680", Slot = "27")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x745C960", Offset = "0x745BD60", VA = "0x18745C960", Slot = "28")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public int JLNMICMFDCK
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x745E9F0", Offset = "0x745DDF0", VA = "0x18745E9F0", Slot = "31")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public GNENMCIDPEM PAGLAEHKACJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x745C720", Offset = "0x745BB20", VA = "0x18745C720", Slot = "29")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public bool GAMAFBGALEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x745CED0", Offset = "0x745C2D0", VA = "0x18745CED0", Slot = "32")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public bool DAGLDKDIDPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x745FF50", Offset = "0x745F350", VA = "0x18745FF50", Slot = "33")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public bool PNIHJIBCNFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x745C390", Offset = "0x745B790", VA = "0x18745C390", Slot = "34")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public OPFMAOOBLLA LGKPJBOBGMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x745FC80", Offset = "0x745F080", VA = "0x18745FC80", Slot = "35")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x745FBC0", Offset = "0x745EFC0", VA = "0x18745FBC0", Slot = "36")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public PAFPNLLDLFP DLCPBKKGFLB
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x745ED20", Offset = "0x745E120", VA = "0x18745ED20", Slot = "37")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x745F800", Offset = "0x745EC00", VA = "0x18745F800", Slot = "38")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public float MGCHCNEGFHE
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x745D2F0", Offset = "0x745C6F0", VA = "0x18745D2F0", Slot = "39")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x745AA30", Offset = "0x7459E30", VA = "0x18745AA30", Slot = "40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public Vector3 BHOHPOALPMD
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x745D730", Offset = "0x745CB30", VA = "0x18745D730", Slot = "41")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x745E7A0", Offset = "0x745DBA0", VA = "0x18745E7A0", Slot = "42")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public Vector3 APBHOELFNPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x745E6C0", Offset = "0x745DAC0", VA = "0x18745E6C0", Slot = "43")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x745BCF0", Offset = "0x745B0F0", VA = "0x18745BCF0", Slot = "44")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public Vector3 LAGAIBFOEEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x745D0F0", Offset = "0x745C4F0", VA = "0x18745D0F0", Slot = "45")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x745C770", Offset = "0x745BB70", VA = "0x18745C770", Slot = "46")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public Vector3 KNNCHNCILOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x745DE10", Offset = "0x745D210", VA = "0x18745DE10", Slot = "47")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x745CBA0", Offset = "0x745BFA0", VA = "0x18745CBA0", Slot = "48")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public bool MFOAFDNOLHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x745D870", Offset = "0x745CC70", VA = "0x18745D870", Slot = "139")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public bool HMHOAFAJDHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x745EB10", Offset = "0x745DF10", VA = "0x18745EB10", Slot = "49")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public bool INBJHNLAIFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x745B2A0", Offset = "0x745A6A0", VA = "0x18745B2A0", Slot = "50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public bool FMHHHMCOOIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x745F360", Offset = "0x745E760", VA = "0x18745F360", Slot = "51")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public Vector3 LBGLBFFMPFG
	{
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x745DA10", Offset = "0x745CE10", VA = "0x18745DA10", Slot = "52")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public Vector3 KLAEBFDLDLL
	{
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x745CC80", Offset = "0x745C080", VA = "0x18745CC80", Slot = "53")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public Vector3 MJDCGLHPNEL
	{
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x7460040", Offset = "0x745F440", VA = "0x187460040", Slot = "54")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x745F650", Offset = "0x745EA50", VA = "0x18745F650", Slot = "55")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public Vector3 NALPKDKIGKK
	{
		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x745F940", Offset = "0x745ED40", VA = "0x18745F940", Slot = "56")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public float CMPNNGPHAJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x745C540", Offset = "0x745B940", VA = "0x18745C540", Slot = "57")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public float BICLGLJPJHG
	{
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x745E880", Offset = "0x745DC80", VA = "0x18745E880", Slot = "58")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x745E990", Offset = "0x745DD90", VA = "0x18745E990", Slot = "59")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public Vector3 PJNENDEALGA
	{
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x745CAC0", Offset = "0x745BEC0", VA = "0x18745CAC0", Slot = "60")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public Quaternion DNCJEDDOJMO
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x745C470", Offset = "0x745B870", VA = "0x18745C470", Slot = "61")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public float GIIOJNIOBNG
	{
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x745C850", Offset = "0x745BC50", VA = "0x18745C850", Slot = "63")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x745CE70", Offset = "0x745C270", VA = "0x18745CE70", Slot = "64")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public float MKKCJHHNAOG
	{
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x745B520", Offset = "0x745A920", VA = "0x18745B520", Slot = "65")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x745A9D0", Offset = "0x7459DD0", VA = "0x18745A9D0", Slot = "66")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public bool JODBLCMDIOP
	{
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x745E0E0", Offset = "0x745D4E0", VA = "0x18745E0E0", Slot = "67")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x745F100", Offset = "0x745E500", VA = "0x18745F100", Slot = "68")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public MLNLAOAECFA CPPBBBPHILE
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x745EC50", Offset = "0x745E050", VA = "0x18745EC50", Slot = "69")]
		get
		{
			return default(MLNLAOAECFA);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x745EF10", Offset = "0x745E310", VA = "0x18745EF10", Slot = "70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public bool OMKBNDMPAEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x745F0B0", Offset = "0x745E4B0", VA = "0x18745F0B0", Slot = "71")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public Transform BAFDECEPINN
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x8B2320", Offset = "0x8B1720", VA = "0x1808B2320", Slot = "72")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	public Vector3 CAOBJIJNKKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x745E1E0", Offset = "0x745D5E0", VA = "0x18745E1E0", Slot = "73")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x745DD20", Offset = "0x745D120", VA = "0x18745DD20", Slot = "74")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public float MKCNLDHEIBG
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x745D6C0", Offset = "0x745CAC0", VA = "0x18745D6C0", Slot = "75")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x745B5D0", Offset = "0x745A9D0", VA = "0x18745B5D0", Slot = "76")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public float JELEBBONDKP
	{
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x745DEF0", Offset = "0x745D2F0", VA = "0x18745DEF0", Slot = "77")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x745FE70", Offset = "0x745F270", VA = "0x18745FE70", Slot = "78")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public Quaternion LFGAIGMMBCL
	{
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x745FFA0", Offset = "0x745F3A0", VA = "0x18745FFA0", Slot = "79")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x745AB40", Offset = "0x7459F40", VA = "0x18745AB40", Slot = "80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	public Vector3 ADKILKCAHGF
	{
		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x745DDD0", Offset = "0x745D1D0", VA = "0x18745DDD0", Slot = "81")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x745C430", Offset = "0x745B830", VA = "0x18745C430", Slot = "82")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public Quaternion CKEEBDBDPCG
	{
		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x745DB90", Offset = "0x745CF90", VA = "0x18745DB90", Slot = "83")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x745F4C0", Offset = "0x745E8C0", VA = "0x18745F4C0", Slot = "84")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public RigidbodyConstraints CCNGDIBBDAG
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x745B710", Offset = "0x745AB10", VA = "0x18745B710", Slot = "85")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x745DF00", Offset = "0x745D300", VA = "0x18745DF00", Slot = "86")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public bool HCNFBODKBFP
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x745BCA0", Offset = "0x745B0A0", VA = "0x18745BCA0", Slot = "87")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x745F3B0", Offset = "0x745E7B0", VA = "0x18745F3B0", Slot = "88")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	public CollisionDetectionMode HBONCPHCCAF
	{
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x745EA60", Offset = "0x745DE60", VA = "0x18745EA60", Slot = "89")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x745BEA0", Offset = "0x745B2A0", VA = "0x18745BEA0", Slot = "90")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public bool BJHHEKDOMOM
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x745FD30", Offset = "0x745F130", VA = "0x18745FD30", Slot = "140")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public bool GBGJLIKBJAA
	{
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x745AC20", Offset = "0x745A020", VA = "0x18745AC20", Slot = "91")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event EIBFAGEEMAF IFCEEFDAHEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x745D6D0", Offset = "0x745CAD0", VA = "0x18745D6D0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x745D810", Offset = "0x745CC10", VA = "0x18745D810", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	public event EIBFAGEEMAF AEIMJFGGBMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x745E180", Offset = "0x745D580", VA = "0x18745E180", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x745FA20", Offset = "0x745EE20", VA = "0x18745FA20", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000019")]
	public event JGNAGMIJHCB PDDMGHPLGCE
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x745D090", Offset = "0x745C490", VA = "0x18745D090", Slot = "18")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x745EAB0", Offset = "0x745DEB0", VA = "0x18745EAB0", Slot = "19")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	public event EIBFAGEEMAF LCICBLPNPKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x745B6B0", Offset = "0x745AAB0", VA = "0x18745B6B0", Slot = "8")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x745B810", Offset = "0x745AC10", VA = "0x18745B810", Slot = "9")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	public event EIBFAGEEMAF LFINLFDFJPP
	{
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x745D290", Offset = "0x745C690", VA = "0x18745D290", Slot = "14")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x745FC20", Offset = "0x745F020", VA = "0x18745FC20", Slot = "15")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001C")]
	public event EIBFAGEEMAF KCEGOHOIJLE
	{
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x745B870", Offset = "0x745AC70", VA = "0x18745B870", Slot = "16")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x745C8A0", Offset = "0x745BCA0", VA = "0x18745C8A0", Slot = "17")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001D")]
	public event Action<JHPLKFFCHDF, JHPLKFFCHDF> LAAJLCKFOHC
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x745B570", Offset = "0x745A970", VA = "0x18745B570", Slot = "20")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x745D010", Offset = "0x745C410", VA = "0x18745D010", Slot = "21")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001E")]
	public event EIBFAGEEMAF BMHAGMABFJE
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x745FCD0", Offset = "0x745F0D0", VA = "0x18745FCD0", Slot = "12")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x745F4F0", Offset = "0x745E8F0", VA = "0x18745F4F0", Slot = "13")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001F")]
	public event EIBFAGEEMAF CEHKLBHNDEK
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x745C110", Offset = "0x745B510", VA = "0x18745C110", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x745B760", Offset = "0x745AB60", VA = "0x18745B760", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x7460160", Offset = "0x745F560", VA = "0x187460160")]
	public NLAMLALBDFJ(GameObject BCDDMHHPJBD, RigidbodyEx GPCHFGDJDEC, ODOBDEHJAPK BLMJILKGBHG, [In] HBBDMOFMLCI AIKOCCMKKAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x745E3D0", Offset = "0x745D7D0", VA = "0x18745E3D0", Slot = "137")]
	protected virtual void LBDCGLICOGD(ODOBDEHJAPK BLMJILKGBHG, HBBDMOFMLCI AIKOCCMKKAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x745BDD0", Offset = "0x745B1D0", VA = "0x18745BDD0", Slot = "138")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x745FA80", Offset = "0x745EE80", VA = "0x18745FA80", Slot = "92")]
	public void OICKCJAMCMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x745D9C0", Offset = "0x745CDC0", VA = "0x18745D9C0", Slot = "93")]
	public void JHKELGPFBMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x745D070", Offset = "0x745C470", VA = "0x18745D070", Slot = "94")]
	public void HBBIBKLJMKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x745ECA0", Offset = "0x745E0A0", VA = "0x18745ECA0")]
	private void LPOOLHJIIMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x745DF60", Offset = "0x745D360", VA = "0x18745DF60", Slot = "30")]
	public GNENMCIDPEM JJHMKPKLGIM(int HAJICDLBEKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x745D1D0", Offset = "0x745C5D0", VA = "0x18745D1D0", Slot = "96")]
	public void HGECDLHOFAC(GNENMCIDPEM EEPLCHCGAIN, bool LCNIJLOJAGJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x745A2E0", Offset = "0x74596E0", VA = "0x18745A2E0", Slot = "97")]
	public void ABINNCCMOAN(object ABHFNNFMPHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x745C900", Offset = "0x745BD00", VA = "0x18745C900", Slot = "98")]
	public void GDBGGEPKNII(object ABHFNNFMPHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x745C290", Offset = "0x745B690", VA = "0x18745C290", Slot = "99")]
	public Vector3 EIFFMIENBIO(Vector3 LFFEGBGDOPO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x745C9C0", Offset = "0x745BDC0", VA = "0x18745C9C0", Slot = "100")]
	public Vector3 GIEDGGBOHPA(Vector3 AHELNOLPMIB)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x745D9C0", Offset = "0x745CDC0", VA = "0x18745D9C0", Slot = "101")]
	public void IJMNINGLFII()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x745B250", Offset = "0x745A650", VA = "0x18745B250", Slot = "102")]
	public void CADKCHJHLHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x745B4D0", Offset = "0x745A8D0", VA = "0x18745B4D0", Slot = "103")]
	public void CFNDDLJCEMO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x745B8D0", Offset = "0x745ACD0", VA = "0x18745B8D0", Slot = "104")]
	public void DJLBKENEHMH(Vector3 FICPNOACCPA, Vector3 MBHKBNFIGNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x745C590", Offset = "0x745B990", VA = "0x18745C590", Slot = "105")]
	public void FFAELKNMIGM(Vector3 KFINDPIHPIF, Vector3 GCFMFJNALIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x745EE30", Offset = "0x745E230", VA = "0x18745EE30", Slot = "106")]
	public void MGOINFGFJOD(Vector3 PCALPEJHEDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x745C050", Offset = "0x745B450", VA = "0x18745C050", Slot = "107")]
	public void EGMKAAINCJN(ECHIOPDOMDO IONCIEEBOBO, Vector3 JOGLJMPKPKH, float PPDEONJIIMA, float OFOGFBIIGGI = 8f, float BJMNFCJBKKE = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x745BF00", Offset = "0x745B300", VA = "0x18745BF00", Slot = "108")]
	public void EFLEMJFNFOP(ECJJLAKNLID KOCJMOOKFFH, Vector3 BBIPOCPEDJM, float JLDDDBDKMNI = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x745DAE0", Offset = "0x745CEE0", VA = "0x18745DAE0", Slot = "109")]
	[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
	public void ILEPDKIGMPO(ECJJLAKNLID KOCJMOOKFFH, Vector3 MDJOMEFJFHD, float BBBGCFNLFEE = 7f, float LDHDIPAMOEN = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x745D8C0", Offset = "0x745CCC0", VA = "0x18745D8C0", Slot = "110")]
	public Vector3 IIPLLEMKFCG(Vector3 EEPLCHCGAIN)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x745ADA0", Offset = "0x745A1A0", VA = "0x18745ADA0", Slot = "111")]
	public Vector3 BOEHOBLDELA(Vector3 EEPLCHCGAIN)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x745E030", Offset = "0x745D430", VA = "0x18745E030", Slot = "112")]
	public void JLGHMDCLJFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x745EF70", Offset = "0x745E370", VA = "0x18745EF70", Slot = "113")]
	public void MIPLODMEAFA(GNENMCIDPEM DFKIPILFANJ, object ABHFNNFMPHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x745AA90", Offset = "0x7459E90", VA = "0x18745AA90", Slot = "114")]
	public void BEEFIIBDPNP(object ABHFNNFMPHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x745E290", Offset = "0x745D690", VA = "0x18745E290", Slot = "62")]
	public void KKAKDEJIFDA((Quaternion rot, Vector3 moments) IFAMPJEONCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x745AAF0", Offset = "0x7459EF0", VA = "0x18745AAF0", Slot = "115")]
	public void BFCJABJNJNJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x745C000", Offset = "0x745B400", VA = "0x18745C000", Slot = "116")]
	public void EGDBGLFOHBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x745DFE0", Offset = "0x745D3E0", VA = "0x18745DFE0", Slot = "117")]
	public void JKLECADOEME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x745E130", Offset = "0x745D530", VA = "0x18745E130", Slot = "118")]
	public bool KCNDEMAKNNC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x745B9C0", Offset = "0x745ADC0", VA = "0x18745B9C0", Slot = "95")]
	public void DLBLJMIMABA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x745C3E0", Offset = "0x745B7E0", VA = "0x18745C3E0", Slot = "119")]
	public void ENCEEBEJNHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x745EDD0", Offset = "0x745E1D0", VA = "0x18745EDD0", Slot = "120")]
	public void MDOKJEKJEPB(object ABHFNNFMPHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x745F410", Offset = "0x745E810", VA = "0x18745F410", Slot = "121")]
	public void NFNBHJKHGPF(object ABHFNNFMPHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x745B640", Offset = "0x745AA40", VA = "0x18745B640", Slot = "122")]
	public void COGFCLDDILJ(object ABHFNNFMPHA, bool PKMIKOAMPIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x745F160", Offset = "0x745E560", VA = "0x18745F160", Slot = "123")]
	public void NDJEINIBCNJ(Vector3 MFPJNNFLIFP, Quaternion LLJELCFPHCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x745A340", Offset = "0x7459740", VA = "0x18745A340", Slot = "124")]
	public void ADCAKFLGNGD(Vector3 IALALBHIOOH, Quaternion BDCEABKAEDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x745C6D0", Offset = "0x745BAD0", VA = "0x18745C6D0", Slot = "125")]
	public bool FJBFPEMPFFB(float KHDOIBPNKOB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x745E080", Offset = "0x745D480", VA = "0x18745E080", Slot = "126")]
	public void JPLLGELEFGC(object ABHFNNFMPHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x745ED70", Offset = "0x745E170", VA = "0x18745ED70", Slot = "127")]
	public void MDHLEIDJAPD(object ABHFNNFMPHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x745D340", Offset = "0x745C740", VA = "0x18745D340", Slot = "128")]
	public void HNNIKFOPAHB(object ABHFNNFMPHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x745E370", Offset = "0x745D770", VA = "0x18745E370", Slot = "129")]
	public void LAJLCBGBEBF(object ABHFNNFMPHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x745CF30", Offset = "0x745C330", VA = "0x18745CF30", Slot = "130")]
	public void GOLMBOBCIAE(Vector3 MALABKOONDB, ForceMode BFEPKKCNFOD = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x745BB90", Offset = "0x745AF90", VA = "0x18745BB90", Slot = "131")]
	public void DMDNKPCMOML(Vector3 MALABKOONDB, Vector3 CLHMEGFDOKF, ForceMode BFEPKKCNFOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x745EB70", Offset = "0x745DF70", VA = "0x18745EB70", Slot = "132")]
	public void LLJKEPGCFPF(Vector3 IHEPDJJOFIK, ForceMode BFEPKKCNFOD = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x745F860", Offset = "0x745EC60", VA = "0x18745F860", Slot = "133")]
	public void OENFINJMCLJ(Vector3 IHEPDJJOFIK, ForceMode BFEPKKCNFOD = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x745B430", Offset = "0x745A830", VA = "0x18745B430", Slot = "134")]
	public bool CDGBDFLPKMM(Vector3 PAAGAJJEHGO, [Out] RaycastHit NKGBAALLKCD, float NHDEHMAPALH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x745D240", Offset = "0x745C640", VA = "0x18745D240", Slot = "135")]
	public void HHLMEAPLHIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x7460120", Offset = "0x745F520", VA = "0x187460120", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x745F730", Offset = "0x745EB30", VA = "0x18745F730")]
	private void OAPNKNKEPPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x745CD60", Offset = "0x745C160", VA = "0x18745CD60")]
	private void GLCCOAOFEFM(GNENMCIDPEM DEDHJMDEEIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x745A7F0", Offset = "0x7459BF0", VA = "0x18745A7F0")]
	private void ALNNJPCHCJK(GNENMCIDPEM DEDHJMDEEIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x745B380", Offset = "0x745A780", VA = "0x18745B380")]
	private void CAKNBMHKCHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x745F550", Offset = "0x745E950", VA = "0x18745F550")]
	private void NOKGMDNEPOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x745BA10", Offset = "0x745AE10", VA = "0x18745BA10")]
	private void DLMJACKNEFL(GNENMCIDPEM CLHCMALLCMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x745EFE0", Offset = "0x745E3E0", VA = "0x18745EFE0")]
	private void MOFEPKJILNI(GNENMCIDPEM DEDHJMDEEIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x745C1C0", Offset = "0x745B5C0", VA = "0x18745C1C0")]
	private void EGPDKDMNMLI(GNENMCIDPEM DEDHJMDEEIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x745DBD0", Offset = "0x745CFD0", VA = "0x18745DBD0")]
	private void INCKANCKAJC(AKFJEGODPDH DEDHJMDEEIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x745AEA0", Offset = "0x745A2A0", VA = "0x18745AEA0", Slot = "141")]
	protected virtual void CABGJFLLBBP(AKFJEGODPDH GJHPLGMALIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x745D3A0", Offset = "0x745C7A0", VA = "0x18745D3A0")]
	protected void HOBHBHADBLL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x745A480", Offset = "0x7459880", VA = "0x18745A480")]
	protected void AFHBBEEIGFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x745E8D0", Offset = "0x745DCD0", VA = "0x18745E8D0", Slot = "142")]
	protected virtual IDisposable LFDIKFEEEIH()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal static class HDJAGCJMOMI
{
	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x7451BA0", Offset = "0x7450FA0", VA = "0x187451BA0")]
	public static GNENMCIDPEM PHDNHHKDFNA(this GNENMCIDPEM GJHPLGMALIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x7451B00", Offset = "0x7450F00", VA = "0x187451B00")]
	public static bool PBMNJMILOBJ(this GNENMCIDPEM GJHPLGMALIK, GNENMCIDPEM LJNHDGKFAKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x7451A10", Offset = "0x7450E10", VA = "0x187451A10")]
	public static bool HAKNKKANJNI(this GNENMCIDPEM GJHPLGMALIK, GNENMCIDPEM CACEHMAIDDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x7451AB0", Offset = "0x7450EB0", VA = "0x187451AB0")]
	public static AKFJEGODPDH HPILEHGILNO(this GNENMCIDPEM JPNNGBEFPIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x74519A0", Offset = "0x7450DA0", VA = "0x1874519A0")]
	public static NLAMLALBDFJ BEDBHIMHDBC(this GNENMCIDPEM JPNNGBEFPIE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class GGJNGBJIHBK : CJFAMILEGNO
{
	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x7451220", Offset = "0x7450620", VA = "0x187451220", Slot = "19")]
	public GNENMCIDPEM LAHOIJPCLLJ(RigidbodyEx GJHPLGMALIK, HBBDMOFMLCI AIKOCCMKKAE, ODOBDEHJAPK BLMJILKGBHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x8AA280", Offset = "0x8A9680", VA = "0x1808AA280", Slot = "4")]
	public MALEKPJFBCF PDFHCHPLBBF(GNENMCIDPEM JPNNGBEFPIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x8AA280", Offset = "0x8A9680", VA = "0x1808AA280", Slot = "5")]
	public JAPLBFANHGD LDFDIMDKIML(GNENMCIDPEM JPNNGBEFPIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x8AA280", Offset = "0x8A9680", VA = "0x1808AA280", Slot = "6")]
	public DNLNOLOCGHB PIECNDDOACE(GNENMCIDPEM JPNNGBEFPIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x8AA280", Offset = "0x8A9680", VA = "0x1808AA280", Slot = "7")]
	public AKKOCMLEJGJ ENJNLMPGIDH(GNENMCIDPEM JPNNGBEFPIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x8AA280", Offset = "0x8A9680", VA = "0x1808AA280", Slot = "8")]
	public CJHDOGPCDKJ IKPJPBKKEIC(GNENMCIDPEM JPNNGBEFPIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x8AA280", Offset = "0x8A9680", VA = "0x1808AA280", Slot = "9")]
	public AMNDOGIPNGK HNKADIOCAAK(GNENMCIDPEM JPNNGBEFPIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x8AA280", Offset = "0x8A9680", VA = "0x1808AA280", Slot = "10")]
	public NHBHBFNDACL PCIDPNGMBEH(GNENMCIDPEM JPNNGBEFPIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x8AA280", Offset = "0x8A9680", VA = "0x1808AA280", Slot = "11")]
	public ICDBJMBBKCB ADLAMNAPBGL(GNENMCIDPEM JPNNGBEFPIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x8AA280", Offset = "0x8A9680", VA = "0x1808AA280", Slot = "12")]
	public CFBEDLKJPDI LLNKHOMPGGL(GNENMCIDPEM JPNNGBEFPIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x8AA280", Offset = "0x8A9680", VA = "0x1808AA280", Slot = "13")]
	public CIAKONMFMIM OHHKGBKJPOB(GNENMCIDPEM JPNNGBEFPIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x8AA280", Offset = "0x8A9680", VA = "0x1808AA280")]
	public DAHLIOGLLCA HLNPGKDPIEA(GNENMCIDPEM JPNNGBEFPIE, [In] HBBDMOFMLCI AIKOCCMKKAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x8AA280", Offset = "0x8A9680", VA = "0x1808AA280")]
	public JDCOHKKMABP FGBLGMBIIFM(GNENMCIDPEM JPNNGBEFPIE, [In] HBBDMOFMLCI AIKOCCMKKAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x8AA280", Offset = "0x8A9680", VA = "0x1808AA280")]
	public IAFNLOGPHDM FNKEIJNCMOF(GNENMCIDPEM JPNNGBEFPIE, [In] HBBDMOFMLCI AIKOCCMKKAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x8AA280", Offset = "0x8A9680", VA = "0x1808AA280")]
	public FECOODOBHCB OCICENNAGEP(GNENMCIDPEM JPNNGBEFPIE, [In] HBBDMOFMLCI AIKOCCMKKAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x8AA280", Offset = "0x8A9680", VA = "0x1808AA280")]
	public EGFCLOFMPEI JNPCPJGMPIG(GNENMCIDPEM JPNNGBEFPIE, [In] HBBDMOFMLCI AIKOCCMKKAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
	public GGJNGBJIHBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x8AA280", Offset = "0x8A9680", VA = "0x1808AA280", Slot = "14")]
	private DAHLIOGLLCA NNHKDEAMKNB(GNENMCIDPEM JPNNGBEFPIE, [In] HBBDMOFMLCI AIKOCCMKKAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x8AA280", Offset = "0x8A9680", VA = "0x1808AA280", Slot = "15")]
	private JDCOHKKMABP CAJLALNKBEI(GNENMCIDPEM JPNNGBEFPIE, [In] HBBDMOFMLCI AIKOCCMKKAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x8AA280", Offset = "0x8A9680", VA = "0x1808AA280", Slot = "16")]
	private IAFNLOGPHDM FMBBFFNMADL(GNENMCIDPEM JPNNGBEFPIE, [In] HBBDMOFMLCI AIKOCCMKKAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x8AA280", Offset = "0x8A9680", VA = "0x1808AA280", Slot = "17")]
	private FECOODOBHCB OPMDGJAJAIB(GNENMCIDPEM JPNNGBEFPIE, [In] HBBDMOFMLCI AIKOCCMKKAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x8AA280", Offset = "0x8A9680", VA = "0x1808AA280", Slot = "18")]
	private EGFCLOFMPEI NLONCGKFHPP(GNENMCIDPEM JPNNGBEFPIE, [In] HBBDMOFMLCI AIKOCCMKKAE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[MEMFFHBLAMF(typeof(CJFAMILEGNO), new string[] { })]
public class LFDPPDBKFEM : CJFAMILEGNO, PCLMMJFGOJL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private readonly CJFAMILEGNO DPGMMAPEMME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private readonly CJFAMILEGNO DCLPOILPFCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private PJAAGGJLMPG JAEGMFGHGGA;

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	private CJFAMILEGNO PCKMFOGMEHC
	{
		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x7459A40", Offset = "0x7458E40", VA = "0x187459A40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x74599F0", Offset = "0x7458DF0", VA = "0x1874599F0", Slot = "20")]
	public void InitReferences(MLIFIICJDOD JGADEBKHJGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x7459F60", Offset = "0x7459360", VA = "0x187459F60", Slot = "4")]
	public MALEKPJFBCF PDFHCHPLBBF(GNENMCIDPEM JPNNGBEFPIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x7459C30", Offset = "0x7459030", VA = "0x187459C30", Slot = "5")]
	public JAPLBFANHGD LDFDIMDKIML(GNENMCIDPEM JPNNGBEFPIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x745A000", Offset = "0x7459400", VA = "0x18745A000", Slot = "6")]
	public DNLNOLOCGHB PIECNDDOACE(GNENMCIDPEM JPNNGBEFPIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x74596B0", Offset = "0x7458AB0", VA = "0x1874596B0", Slot = "7")]
	public AKKOCMLEJGJ ENJNLMPGIDH(GNENMCIDPEM JPNNGBEFPIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x7459950", Offset = "0x7458D50", VA = "0x187459950", Slot = "8")]
	public CJHDOGPCDKJ IKPJPBKKEIC(GNENMCIDPEM JPNNGBEFPIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x74598B0", Offset = "0x7458CB0", VA = "0x1874598B0", Slot = "9")]
	public AMNDOGIPNGK HNKADIOCAAK(GNENMCIDPEM JPNNGBEFPIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x7459EC0", Offset = "0x74592C0", VA = "0x187459EC0", Slot = "10")]
	public NHBHBFNDACL PCIDPNGMBEH(GNENMCIDPEM JPNNGBEFPIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x7459560", Offset = "0x7458960", VA = "0x187459560", Slot = "11")]
	public ICDBJMBBKCB ADLAMNAPBGL(GNENMCIDPEM JPNNGBEFPIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x7459CD0", Offset = "0x74590D0", VA = "0x187459CD0", Slot = "12")]
	public CFBEDLKJPDI LLNKHOMPGGL(GNENMCIDPEM JPNNGBEFPIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x7459E20", Offset = "0x7459220", VA = "0x187459E20", Slot = "13")]
	public CIAKONMFMIM OHHKGBKJPOB(GNENMCIDPEM JPNNGBEFPIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x7459800", Offset = "0x7458C00", VA = "0x187459800")]
	public DAHLIOGLLCA HLNPGKDPIEA(GNENMCIDPEM JPNNGBEFPIE, [In] HBBDMOFMLCI AIKOCCMKKAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x7459600", Offset = "0x7458A00", VA = "0x187459600")]
	public JDCOHKKMABP FGBLGMBIIFM(GNENMCIDPEM JPNNGBEFPIE, [In] HBBDMOFMLCI AIKOCCMKKAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x7459750", Offset = "0x7458B50", VA = "0x187459750")]
	public IAFNLOGPHDM FNKEIJNCMOF(GNENMCIDPEM JPNNGBEFPIE, [In] HBBDMOFMLCI AIKOCCMKKAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x7459D70", Offset = "0x7459170", VA = "0x187459D70")]
	public FECOODOBHCB OCICENNAGEP(GNENMCIDPEM JPNNGBEFPIE, [In] HBBDMOFMLCI AIKOCCMKKAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x7459AA0", Offset = "0x7458EA0", VA = "0x187459AA0")]
	public EGFCLOFMPEI JNPCPJGMPIG(GNENMCIDPEM JPNNGBEFPIE, [In] HBBDMOFMLCI AIKOCCMKKAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x7459B50", Offset = "0x7458F50", VA = "0x187459B50", Slot = "19")]
	public GNENMCIDPEM LAHOIJPCLLJ(RigidbodyEx GJHPLGMALIK, HBBDMOFMLCI AIKOCCMKKAE, ODOBDEHJAPK BLMJILKGBHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x745A0A0", Offset = "0x74594A0", VA = "0x18745A0A0")]
	public LFDPPDBKFEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x7459800", Offset = "0x7458C00", VA = "0x187459800", Slot = "14")]
	private DAHLIOGLLCA NNHKDEAMKNB(GNENMCIDPEM JPNNGBEFPIE, [In] HBBDMOFMLCI AIKOCCMKKAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x7459600", Offset = "0x7458A00", VA = "0x187459600", Slot = "15")]
	private JDCOHKKMABP CAJLALNKBEI(GNENMCIDPEM JPNNGBEFPIE, [In] HBBDMOFMLCI AIKOCCMKKAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x7459750", Offset = "0x7458B50", VA = "0x187459750", Slot = "16")]
	private IAFNLOGPHDM FMBBFFNMADL(GNENMCIDPEM JPNNGBEFPIE, [In] HBBDMOFMLCI AIKOCCMKKAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x7459D70", Offset = "0x7459170", VA = "0x187459D70", Slot = "17")]
	private FECOODOBHCB OPMDGJAJAIB(GNENMCIDPEM JPNNGBEFPIE, [In] HBBDMOFMLCI AIKOCCMKKAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x7459AA0", Offset = "0x7458EA0", VA = "0x187459AA0", Slot = "18")]
	private EGFCLOFMPEI NLONCGKFHPP(GNENMCIDPEM JPNNGBEFPIE, [In] HBBDMOFMLCI AIKOCCMKKAE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface JGJHDMICPEE : MALEKPJFBCF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BHKAAHKPFIE(GNENMCIDPEM GJHPLGMALIK);

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DJGNDELDFNH(GNENMCIDPEM GJHPLGMALIK);

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NGDKNEEAOPL(GNENMCIDPEM CLHCMALLCMJ);

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void AHPNLEINFNI(GNENMCIDPEM CLHCMALLCMJ);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface PPDGDFFIDOH : DNLNOLOCGHB
{
	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	JGNIEIOFKJG<GNENMCIDPEM> AEIBAENENPC
	{
		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	GNENMCIDPEM NJCIBPIANCH
	{
		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface AGFLBANIJAG : FECOODOBHCB
{
	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	(float, Vector3) JDAMGNOLCIL(Rigidbody LOKCAOMOPIO);
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public interface FKJPPMMNNEF : JDCOHKKMABP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	PhotonView FIIKIFDEBFH
	{
		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal sealed class DBANJJFPCNI : CFBEDLKJPDI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private readonly NLAMLALBDFJ GJHPLGMALIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private CollisionDetectionMode GDGLJBOPOGO;

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	private Rigidbody KIKAKLALKIE
	{
		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x744AC80", Offset = "0x744A080", VA = "0x18744AC80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public CollisionDetectionMode HBONCPHCCAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x744B8C0", Offset = "0x744ACC0", VA = "0x18744B8C0", Slot = "4")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x744B850", Offset = "0x744AC50", VA = "0x18744B850", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x744AF30", Offset = "0x744A330", VA = "0x18744AF30")]
	public DBANJJFPCNI(GNENMCIDPEM GJHPLGMALIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x744B9E0", Offset = "0x744ADE0", VA = "0x18744B9E0", Slot = "6")]
	public void OICKCJAMCMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x744B670", Offset = "0x744AA70", VA = "0x18744B670", Slot = "9")]
	public void BMHAAMJPCLN(Rigidbody KLDNEBDEBMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x744BAF0", Offset = "0x744AEF0", VA = "0x18744BAF0", Slot = "7")]
	public void OJDJMGJMOOG(bool HHDMKGALEHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x744B9D0", Offset = "0x744ADD0", VA = "0x18744B9D0", Slot = "8")]
	public void MPCEJMPGENI(bool HHDMKGALEHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x744B6F0", Offset = "0x744AAF0", VA = "0x18744B6F0", Slot = "10")]
	public bool CDGBDFLPKMM(Vector3 PAAGAJJEHGO, [Out] RaycastHit NKGBAALLKCD, float NHDEHMAPALH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x744BB00", Offset = "0x744AF00", VA = "0x18744BB00")]
	private void OKGAMMLEEFH(bool HHDMKGALEHG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class GOINEOGJPAN : AMNDOGIPNGK, IDisposable, HAMADHEGBGJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private readonly NLAMLALBDFJ GJHPLGMALIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private MLNLAOAECFA IMIPLEFLJBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private MIIBBEHCOHE PGNHFFOEINB;

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public MLNLAOAECFA CPPBBBPHILE
	{
		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x7451490", Offset = "0x7450890", VA = "0x187451490", Slot = "6")]
		get
		{
			return default(MLNLAOAECFA);
		}
		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x74515D0", Offset = "0x74509D0", VA = "0x1874515D0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	private Transform JDIGBOGIFED
	{
		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x74512C0", Offset = "0x74506C0", VA = "0x1874512C0", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000020")]
	public event Action<JHPLKFFCHDF, JHPLKFFCHDF> LAAJLCKFOHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x74512E0", Offset = "0x74506E0", VA = "0x1874512E0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x74513E0", Offset = "0x74507E0", VA = "0x1874513E0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x7451910", Offset = "0x7450D10", VA = "0x187451910")]
	public GOINEOGJPAN(GNENMCIDPEM GJHPLGMALIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x74516A0", Offset = "0x7450AA0", VA = "0x1874516A0", Slot = "8")]
	public void OICKCJAMCMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x7451390", Offset = "0x7450790", VA = "0x187451390", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0xC5ADE0", Offset = "0xC5A1E0", VA = "0x180C5ADE0", Slot = "11")]
	private void OBALGMIPJCK(JHPLKFFCHDF NJKDGCIALCM, JHPLKFFCHDF KGBIGAKOKLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x8AA270", Offset = "0x8A9670", VA = "0x1808AA270", Slot = "12")]
	private void AGMKKEOMCGA(bool NEEIAEKHOHG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class HLOPMMJFJIH : CJFAMILEGNO
{
	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x74567D0", Offset = "0x7455BD0", VA = "0x1874567D0", Slot = "4")]
	public MALEKPJFBCF PDFHCHPLBBF(GNENMCIDPEM JPNNGBEFPIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x7456280", Offset = "0x7455680", VA = "0x187456280", Slot = "5")]
	public JAPLBFANHGD LDFDIMDKIML(GNENMCIDPEM JPNNGBEFPIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x74568C0", Offset = "0x7455CC0", VA = "0x1874568C0", Slot = "6")]
	public DNLNOLOCGHB PIECNDDOACE(GNENMCIDPEM JPNNGBEFPIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x7455BC0", Offset = "0x7454FC0", VA = "0x187455BC0", Slot = "7")]
	public AKKOCMLEJGJ ENJNLMPGIDH(GNENMCIDPEM JPNNGBEFPIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x7455F80", Offset = "0x7455380", VA = "0x187455F80", Slot = "8")]
	public CJHDOGPCDKJ IKPJPBKKEIC(GNENMCIDPEM JPNNGBEFPIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x7455EB0", Offset = "0x74552B0", VA = "0x187455EB0", Slot = "9")]
	public AMNDOGIPNGK HNKADIOCAAK(GNENMCIDPEM JPNNGBEFPIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x74566B0", Offset = "0x7455AB0", VA = "0x1874566B0", Slot = "10")]
	public NHBHBFNDACL PCIDPNGMBEH(GNENMCIDPEM JPNNGBEFPIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x7455970", Offset = "0x7454D70", VA = "0x187455970", Slot = "11")]
	public ICDBJMBBKCB ADLAMNAPBGL(GNENMCIDPEM JPNNGBEFPIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x74563A0", Offset = "0x74557A0", VA = "0x1874563A0", Slot = "12")]
	public CFBEDLKJPDI LLNKHOMPGGL(GNENMCIDPEM JPNNGBEFPIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x74565F0", Offset = "0x74559F0", VA = "0x1874565F0", Slot = "13")]
	public CIAKONMFMIM OHHKGBKJPOB(GNENMCIDPEM JPNNGBEFPIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x7455D70", Offset = "0x7455170", VA = "0x187455D70")]
	public DAHLIOGLLCA HLNPGKDPIEA(GNENMCIDPEM JPNNGBEFPIE, [In] HBBDMOFMLCI AIKOCCMKKAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x7455A30", Offset = "0x7454E30", VA = "0x187455A30")]
	public JDCOHKKMABP FGBLGMBIIFM(GNENMCIDPEM JPNNGBEFPIE, [In] HBBDMOFMLCI AIKOCCMKKAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x7455C40", Offset = "0x7455040", VA = "0x187455C40")]
	public IAFNLOGPHDM FNKEIJNCMOF(GNENMCIDPEM JPNNGBEFPIE, [In] HBBDMOFMLCI AIKOCCMKKAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x7456460", Offset = "0x7455860", VA = "0x187456460")]
	public FECOODOBHCB OCICENNAGEP(GNENMCIDPEM JPNNGBEFPIE, [In] HBBDMOFMLCI AIKOCCMKKAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x7456050", Offset = "0x7455450", VA = "0x187456050")]
	public EGFCLOFMPEI JNPCPJGMPIG(GNENMCIDPEM JPNNGBEFPIE, [In] HBBDMOFMLCI AIKOCCMKKAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x7456130", Offset = "0x7455530", VA = "0x187456130", Slot = "19")]
	public GNENMCIDPEM LAHOIJPCLLJ(RigidbodyEx GJHPLGMALIK, HBBDMOFMLCI AIKOCCMKKAE, ODOBDEHJAPK BLMJILKGBHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
	public HLOPMMJFJIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x7455D70", Offset = "0x7455170", VA = "0x187455D70", Slot = "14")]
	private DAHLIOGLLCA NNHKDEAMKNB(GNENMCIDPEM JPNNGBEFPIE, [In] HBBDMOFMLCI AIKOCCMKKAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x7455A30", Offset = "0x7454E30", VA = "0x187455A30", Slot = "15")]
	private JDCOHKKMABP CAJLALNKBEI(GNENMCIDPEM JPNNGBEFPIE, [In] HBBDMOFMLCI AIKOCCMKKAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x7455C40", Offset = "0x7455040", VA = "0x187455C40", Slot = "16")]
	private IAFNLOGPHDM FMBBFFNMADL(GNENMCIDPEM JPNNGBEFPIE, [In] HBBDMOFMLCI AIKOCCMKKAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x7456460", Offset = "0x7455860", VA = "0x187456460", Slot = "17")]
	private FECOODOBHCB OPMDGJAJAIB(GNENMCIDPEM JPNNGBEFPIE, [In] HBBDMOFMLCI AIKOCCMKKAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x7456050", Offset = "0x7455450", VA = "0x187456050", Slot = "18")]
	private EGFCLOFMPEI NLONCGKFHPP(GNENMCIDPEM JPNNGBEFPIE, [In] HBBDMOFMLCI AIKOCCMKKAE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
internal sealed class BBCDHLNGLKC : ICDBJMBBKCB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly NLAMLALBDFJ GJHPLGMALIK;

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	private Rigidbody KIKAKLALKIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x744AC80", Offset = "0x744A080", VA = "0x18744AC80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	private bool OMKBNDMPAEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x744AC30", Offset = "0x744A030", VA = "0x18744AC30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	private bool GAMAFBGALEN
	{
		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x744A6B0", Offset = "0x7449AB0", VA = "0x18744A6B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	private GNENMCIDPEM CNLABKPDMID
	{
		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x744A650", Offset = "0x7449A50", VA = "0x18744A650")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x744AF30", Offset = "0x744A330", VA = "0x18744AF30")]
	public BBCDHLNGLKC(GNENMCIDPEM GJHPLGMALIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x744A710", Offset = "0x7449B10", VA = "0x18744A710", Slot = "4")]
	public void GOLMBOBCIAE(Vector3 MALABKOONDB, ForceMode BFEPKKCNFOD = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x744A170", Offset = "0x7449570", VA = "0x18744A170")]
	private void AFNJDILGLCI(Vector3 MALABKOONDB, ForceMode BFEPKKCNFOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x744A3D0", Offset = "0x74497D0", VA = "0x18744A3D0", Slot = "5")]
	public void DMDNKPCMOML(Vector3 MALABKOONDB, Vector3 CLHMEGFDOKF, ForceMode BFEPKKCNFOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x744A870", Offset = "0x7449C70", VA = "0x18744A870", Slot = "6")]
	public void LLJKEPGCFPF(Vector3 IHEPDJJOFIK, ForceMode BFEPKKCNFOD = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x744A9D0", Offset = "0x7449DD0", VA = "0x18744A9D0")]
	private void NADDHFCKDKM(Vector3 IHEPDJJOFIK, ForceMode BFEPKKCNFOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x744ACD0", Offset = "0x744A0D0", VA = "0x18744ACD0", Slot = "7")]
	public void OENFINJMCLJ(Vector3 IHEPDJJOFIK, ForceMode BFEPKKCNFOD = ForceMode.Force)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal sealed class CBDLCDBECKE : CIAKONMFMIM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly NLAMLALBDFJ GJHPLGMALIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private bool DPPCADMPFNK;

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public bool JODBLCMDIOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0xB47470", Offset = "0xB46870", VA = "0x180B47470", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x744B560", Offset = "0x744A960", VA = "0x18744B560", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x744AF30", Offset = "0x744A330", VA = "0x18744AF30")]
	public CBDLCDBECKE(GNENMCIDPEM GJHPLGMALIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(RVA = "0x744B4C0", Offset = "0x744A8C0", VA = "0x18744B4C0", Slot = "6")]
	public void BMHAAMJPCLN(Rigidbody KLDNEBDEBMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x744B4F0", Offset = "0x744A8F0", VA = "0x18744B4F0", Slot = "7")]
	public void GOPOMIDILEH(Rigidbody KLDNEBDEBMN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal sealed class EJDPIOBMIMJ : JGJHDMICPEE, MALEKPJFBCF, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly GNENMCIDPEM GJHPLGMALIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly List<GNENMCIDPEM> POLNGMAPPMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private GNENMCIDPEM KCFGMPGPMFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private GNENMCIDPEM DEDHJMDEEIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private Transform PGHIGDEKLIB;

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	private Transform BDJMNGJGEPI
	{
		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x744F790", Offset = "0x744EB90", VA = "0x18744F790")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public GNENMCIDPEM CNLABKPDMID
	{
		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x8ACAE0", Offset = "0x8ABEE0", VA = "0x1808ACAE0", Slot = "28")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x744FDA0", Offset = "0x744F1A0", VA = "0x18744FDA0", Slot = "29")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public GNENMCIDPEM PAGLAEHKACJ
	{
		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x8ACB00", Offset = "0x8ABF00", VA = "0x1808ACB00", Slot = "27")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public IReadOnlyList<GNENMCIDPEM> NIHHOEPBMGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x8ACB10", Offset = "0x8ABF10", VA = "0x1808ACB10", Slot = "26")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000021")]
	public event EIBFAGEEMAF IFCEEFDAHEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x7450490", Offset = "0x744F890", VA = "0x187450490", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x7450530", Offset = "0x744F930", VA = "0x187450530", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000022")]
	public event EIBFAGEEMAF AEIMJFGGBMI
	{
		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x7450670", Offset = "0x744FA70", VA = "0x187450670", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x7450CF0", Offset = "0x74500F0", VA = "0x187450CF0", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000023")]
	public event JGNAGMIJHCB PDDMGHPLGCE
	{
		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x744FDB0", Offset = "0x744F1B0", VA = "0x18744FDB0", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x74507F0", Offset = "0x744FBF0", VA = "0x1874507F0", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000024")]
	public event Action NFAAMLDIMFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x7450710", Offset = "0x744FB10", VA = "0x187450710", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x7450EE0", Offset = "0x74502E0", VA = "0x187450EE0", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000025")]
	public event Action AMGKGMEFEPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x7450C50", Offset = "0x7450050", VA = "0x187450C50", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x744FD00", Offset = "0x744F100", VA = "0x18744FD00", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000026")]
	public event Action<GNENMCIDPEM> MGHKLODBEAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x7450930", Offset = "0x744FD30", VA = "0x187450930", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x7450E30", Offset = "0x7450230", VA = "0x187450E30", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000027")]
	public event Action<GNENMCIDPEM> HMLGHAEINDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x744F6E0", Offset = "0x744EAE0", VA = "0x18744F6E0", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x7450F80", Offset = "0x7450380", VA = "0x187450F80", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000028")]
	public event Action NHOJFFLKPJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x7450890", Offset = "0x744FC90", VA = "0x187450890", Slot = "22")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x74505D0", Offset = "0x744F9D0", VA = "0x1874505D0", Slot = "23")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000029")]
	public event Action<GNENMCIDPEM> EJDHADNFOAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x744FBA0", Offset = "0x744EFA0", VA = "0x18744FBA0", Slot = "24")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x744FC50", Offset = "0x744F050", VA = "0x18744FC50", Slot = "25")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600027B")]
	[Cpp2IlInjected.Address(RVA = "0x7451160", Offset = "0x7450560", VA = "0x187451160")]
	public EJDPIOBMIMJ(GNENMCIDPEM GJHPLGMALIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027C")]
	[Cpp2IlInjected.Address(RVA = "0x744FB00", Offset = "0x744EF00", VA = "0x18744FB00", Slot = "31")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000281")]
	[Cpp2IlInjected.Address(RVA = "0x744FF10", Offset = "0x744F310", VA = "0x18744FF10", Slot = "30")]
	public void HGECDLHOFAC(GNENMCIDPEM LNNICEPGDAG, bool LCNIJLOJAGJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000282")]
	[Cpp2IlInjected.Address(RVA = "0x74509E0", Offset = "0x744FDE0", VA = "0x1874509E0", Slot = "6")]
	public void NGDKNEEAOPL(GNENMCIDPEM CLHCMALLCMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000283")]
	[Cpp2IlInjected.Address(RVA = "0x744F350", Offset = "0x744E750", VA = "0x18744F350", Slot = "7")]
	public void AHPNLEINFNI(GNENMCIDPEM CLHCMALLCMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(RVA = "0x744F5D0", Offset = "0x744E9D0", VA = "0x18744F5D0", Slot = "4")]
	public void BHKAAHKPFIE(GNENMCIDPEM GJHPLGMALIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000285")]
	[Cpp2IlInjected.Address(RVA = "0x744FA60", Offset = "0x744EE60", VA = "0x18744FA60", Slot = "5")]
	public void DJGNDELDFNH(GNENMCIDPEM GJHPLGMALIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000286")]
	[Cpp2IlInjected.Address(RVA = "0x7450D90", Offset = "0x7450190", VA = "0x187450D90")]
	private void OOBCPKFBOCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(RVA = "0x74507B0", Offset = "0x744FBB0", VA = "0x1874507B0")]
	private void LKANCCNKDOK(GNENMCIDPEM CLHCMALLCMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(RVA = "0x744F7F0", Offset = "0x744EBF0", VA = "0x18744F7F0")]
	private void CFGAHGEADHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x7451030", Offset = "0x7450430", VA = "0x187451030")]
	private void POGPKFHMLNM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x744F930", Offset = "0x744ED30", VA = "0x18744F930")]
	private void CIPPDNNPIMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(RVA = "0x744FE50", Offset = "0x744F250", VA = "0x18744FE50")]
	[CompilerGenerated]
	private object HCKJKOIIEKP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal static class LLECAECMAGJ
{
	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(RVA = "0x745A150", Offset = "0x7459550", VA = "0x18745A150")]
	public static JGJHDMICPEE KHJCAJHAJIN(this GNENMCIDPEM JPNNGBEFPIE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal sealed class IKJAGMHGKMF : PPDGDFFIDOH, DNLNOLOCGHB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly NLAMLALBDFJ GJHPLGMALIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private readonly JGNIEIOFKJG<GNENMCIDPEM> KLCMEGGJANF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private bool DLGBFNDCIFI;

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public JGNIEIOFKJG<GNENMCIDPEM> AEIBAENENPC
	{
		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x8A89C0", Offset = "0x8A7DC0", VA = "0x1808A89C0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public Vector3 LBGLBFFMPFG
	{
		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x7457630", Offset = "0x7456A30", VA = "0x187457630", Slot = "6")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public Vector3 KLAEBFDLDLL
	{
		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x7456EB0", Offset = "0x74562B0", VA = "0x187456EB0", Slot = "7")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	private Vector3 LAGAIBFOEEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x74571B0", Offset = "0x74565B0", VA = "0x1874571B0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public GNENMCIDPEM NJCIBPIANCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x7457660", Offset = "0x7456A60", VA = "0x187457660", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x7457770", Offset = "0x7456B70", VA = "0x187457770")]
	public IKJAGMHGKMF(GNENMCIDPEM GJHPLGMALIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x7456E40", Offset = "0x7456240", VA = "0x187456E40", Slot = "8")]
	public void DGOGNNKLONK(GNENMCIDPEM DEDHJMDEEIE, object ABHFNNFMPHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x7457710", Offset = "0x7456B10", VA = "0x187457710", Slot = "9")]
	public void MIGJIDHNDIP(object ABHFNNFMPHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x7457290", Offset = "0x7456690", VA = "0x187457290")]
	private Vector3 HFGLDOKCCLM()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x7456AB0", Offset = "0x7455EB0", VA = "0x187456AB0")]
	private void DGCJJEFPMEN(GNENMCIDPEM OEDMHHJCHLL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal static class IBKPENOKHCA
{
	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x74569F0", Offset = "0x7455DF0", VA = "0x1874569F0")]
	public static PPDGDFFIDOH AAAFKBGJLIJ(this GNENMCIDPEM JPNNGBEFPIE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal sealed class DEKAIBDAIMM : AGFLBANIJAG, FECOODOBHCB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private readonly NLAMLALBDFJ GJHPLGMALIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private readonly OverridableVector3 HLPHMHEEKLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private readonly OverridableVector3 DPJDAGBFMPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private float OEDOLBEBPAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private float IPFNNAPKOMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private Vector3 EELMIDPBNNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private Vector3? GDOAKHFJMIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private Quaternion? MOHECIHCDGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private bool PFPLHKCBPEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x79")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private bool PFONAEOCNEG;

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public Vector3 MJDCGLHPNEL
	{
		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x1054D30", Offset = "0x1054130", VA = "0x181054D30", Slot = "7")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x744BDD0", Offset = "0x744B1D0", VA = "0x18744BDD0", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public Vector3 NALPKDKIGKK
	{
		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x744E350", Offset = "0x744D750", VA = "0x18744E350", Slot = "9")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public float CMPNNGPHAJJ
	{
		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0xB47490", Offset = "0xB46890", VA = "0x180B47490", Slot = "10")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x744DD80", Offset = "0x744D180", VA = "0x18744DD80")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public float BICLGLJPJHG
	{
		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0xB47480", Offset = "0xB46880", VA = "0x180B47480", Slot = "11")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x744E0C0", Offset = "0x744D4C0", VA = "0x18744E0C0", Slot = "12")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public Vector3 PJNENDEALGA
	{
		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x744C260", Offset = "0x744B660", VA = "0x18744C260", Slot = "13")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public Quaternion DNCJEDDOJMO
	{
		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x744C0E0", Offset = "0x744B4E0", VA = "0x18744C0E0", Slot = "14")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	private Rigidbody KIKAKLALKIE
	{
		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x744E170", Offset = "0x744D570", VA = "0x18744E170")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002A")]
	public event EIBFAGEEMAF AIJLPDKCNPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x744BF60", Offset = "0x744B360", VA = "0x18744BF60", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x744E1C0", Offset = "0x744D5C0", VA = "0x18744E1C0", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x744E440", Offset = "0x744D840", VA = "0x18744E440")]
	public DEKAIBDAIMM(GNENMCIDPEM GJHPLGMALIK, [In] HBBDMOFMLCI AIKOCCMKKAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x744BC20", Offset = "0x744B020", VA = "0x18744BC20", Slot = "17")]
	public void BFCJABJNJNJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x744C000", Offset = "0x744B400", VA = "0x18744C000", Slot = "16")]
	public void EGDBGLFOHBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(RVA = "0x744BE80", Offset = "0x744B280", VA = "0x18744BE80", Slot = "19")]
	public void BMHAAMJPCLN(Rigidbody KLDNEBDEBMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x744C570", Offset = "0x744B970", VA = "0x18744C570", Slot = "20")]
	public void GOPOMIDILEH(Rigidbody KLDNEBDEBMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x744DBE0", Offset = "0x744CFE0", VA = "0x18744DBE0", Slot = "18")]
	public void JKLECADOEME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x744C8F0", Offset = "0x744BCF0", VA = "0x18744C8F0", Slot = "21")]
	public void HHLMEAPLHIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x744BDD0", Offset = "0x744B1D0", VA = "0x18744BDD0")]
	private void BFHNPCBCHFC(Vector3 EEPLCHCGAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x744E260", Offset = "0x744D660", VA = "0x18744E260")]
	[Obsolete("This method is dangerous - the unity rigidbody is updated in a deferred manner and this world position may be stale")]
	private Vector3 NNODMOHAFKN()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x744DD80", Offset = "0x744D180", VA = "0x18744DD80")]
	private void KEIJJHEDKKB(float EEPLCHCGAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x744E0C0", Offset = "0x744D4C0", VA = "0x18744E0C0")]
	private void PPFAKBDDGIB(float EEPLCHCGAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x744C750", Offset = "0x744BB50", VA = "0x18744C750")]
	private Vector3 HCFHJKCOPGJ()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x744DE90", Offset = "0x744D290", VA = "0x18744DE90", Slot = "15")]
	public void KKAKDEJIFDA((Quaternion rot, Vector3 moments) IFAMPJEONCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x744C3F0", Offset = "0x744B7F0", VA = "0x18744C3F0")]
	private Quaternion GJOAIOLAKLI()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x744DB10", Offset = "0x744CF10", VA = "0x18744DB10")]
	public void JDAMGNOLCIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x744CD70", Offset = "0x744C170", VA = "0x18744CD70", Slot = "4")]
	public (float, Vector3) JDAMGNOLCIL(Rigidbody LOKCAOMOPIO)
	{
		return default((float, Vector3));
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal static class PCFOAEIGNLM
{
	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x74602C0", Offset = "0x745F6C0", VA = "0x1874602C0")]
	public static AGFLBANIJAG BFAHEAPPGOD(this GNENMCIDPEM JPNNGBEFPIE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal sealed class JECDOLJGEPD : IAFNLOGPHDM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private readonly NLAMLALBDFJ GJHPLGMALIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private readonly GDCNMJIEPIF CBPCCCMMBFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private readonly LGMGBDCHIJJ LGKAHCGFMBH;

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public bool NOLILIIKOMP
	{
		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x11F6010", Offset = "0x11F5410", VA = "0x1811F6010", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public LGMGBDCHIJJ JNCKMHILAHG
	{
		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x92A830", Offset = "0x929C30", VA = "0x18092A830", Slot = "11")]
		get
		{
			return default(LGMGBDCHIJJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x7457E80", Offset = "0x7457280", VA = "0x187457E80")]
	public JECDOLJGEPD(GNENMCIDPEM GJHPLGMALIK, [In] HBBDMOFMLCI AIKOCCMKKAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x7457DB0", Offset = "0x74571B0", VA = "0x187457DB0", Slot = "4")]
	public void OICKCJAMCMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x7457CE0", Offset = "0x74570E0", VA = "0x187457CE0")]
	private bool NHJNFKJOCKP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x7457D80", Offset = "0x7457180", VA = "0x187457D80", Slot = "5")]
	public void NNHKBEFOLHD(object ABHFNNFMPHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x7457C70", Offset = "0x7457070", VA = "0x187457C70", Slot = "6")]
	public void JMIFIJKGOFB(object ABHFNNFMPHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x74579C0", Offset = "0x7456DC0", VA = "0x1874579C0", Slot = "9")]
	public void ICLONOGELBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x7457870", Offset = "0x7456C70", VA = "0x187457870")]
	private void EOECKDBPLJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x7457AF0", Offset = "0x7456EF0", VA = "0x187457AF0")]
	private void IIKPBAFHAIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x7457CA0", Offset = "0x74570A0", VA = "0x187457CA0", Slot = "8")]
	public void LNHCOLCLNEA(GNENMCIDPEM GJHPLGMALIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x7457980", Offset = "0x7456D80", VA = "0x187457980", Slot = "7")]
	public void HFCLPMKMAOF(GNENMCIDPEM GJHPLGMALIK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal sealed class BOHPOMHFNKA : NHBHBFNDACL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private readonly NLAMLALBDFJ GJHPLGMALIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly GDCNMJIEPIF JOAJAICAAKB;

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public bool OMKBNDMPAEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x744B1D0", Offset = "0x744A5D0", VA = "0x18744B1D0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002B")]
	public event EIBFAGEEMAF BMHAGMABFJE
	{
		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x744B330", Offset = "0x744A730", VA = "0x18744B330", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x744B290", Offset = "0x744A690", VA = "0x18744B290", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x744B3D0", Offset = "0x744A7D0", VA = "0x18744B3D0")]
	public BOHPOMHFNKA(GNENMCIDPEM GJHPLGMALIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x744B1C0", Offset = "0x744A5C0", VA = "0x18744B1C0", Slot = "7")]
	public void MDOKJEKJEPB(object ABHFNNFMPHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x744B280", Offset = "0x744A680", VA = "0x18744B280", Slot = "8")]
	public void NFNBHJKHGPF(object ABHFNNFMPHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x744B040", Offset = "0x744A440", VA = "0x18744B040", Slot = "9")]
	public void COGFCLDDILJ(object ABHFNNFMPHA, bool PKMIKOAMPIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x744B150", Offset = "0x744A550", VA = "0x18744B150", Slot = "12")]
	public void EIMHMBELKHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x744AFC0", Offset = "0x744A3C0", VA = "0x18744AFC0", Slot = "10")]
	public void BMHAAMJPCLN(Rigidbody FLPMJAFBFIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x744B190", Offset = "0x744A590", VA = "0x18744B190", Slot = "11")]
	public void GOPOMIDILEH(Rigidbody KLDNEBDEBMN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal sealed class DFNHHNNCBMH : FKJPPMMNNEF, JDCOHKKMABP, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private readonly NLAMLALBDFJ GJHPLGMALIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private PhotonView KKBKFEKPJDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private bool LBNOJBOLDKI;

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public PhotonView FIIKIFDEBFH
	{
		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x8A89D0", Offset = "0x8A7DD0", VA = "0x1808A89D0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public bool DAGLDKDIDPH
	{
		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x744F120", Offset = "0x744E520", VA = "0x18744F120", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public bool PNIHJIBCNFL
	{
		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x9439B0", Offset = "0x942DB0", VA = "0x1809439B0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002C")]
	public event EIBFAGEEMAF LCICBLPNPKE
	{
		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x744E6F0", Offset = "0x744DAF0", VA = "0x18744E6F0", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x744E790", Offset = "0x744DB90", VA = "0x18744E790", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x744F140", Offset = "0x744E540", VA = "0x18744F140")]
	public DFNHHNNCBMH(GNENMCIDPEM GJHPLGMALIK, [In] HBBDMOFMLCI AIKOCCMKKAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x744EE80", Offset = "0x744E280", VA = "0x18744EE80", Slot = "9")]
	public void OICKCJAMCMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x744E830", Offset = "0x744DC30", VA = "0x18744E830", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x744ED10", Offset = "0x744E110", VA = "0x18744ED10", Slot = "10")]
	public void MOFEPKJILNI(GNENMCIDPEM DEDHJMDEEIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x744E930", Offset = "0x744DD30", VA = "0x18744E930", Slot = "11")]
	public void EGPDKDMNMLI(GNENMCIDPEM DEDHJMDEEIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x744EFB0", Offset = "0x744E3B0", VA = "0x18744EFB0")]
	private void OLKJLMJBFNJ(PhotonView LOPJFOPBENG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x744E5A0", Offset = "0x744D9A0", VA = "0x18744E5A0")]
	private void AMOBCHHPBAN(AKFJEGODPDH EJFMIJCDGGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x744EAA0", Offset = "0x744DEA0", VA = "0x18744EAA0")]
	private void GBGOMFOMDLD(PhotonView INBGGPOCMKK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
internal static class EGADENAKAFI
{
	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x744F290", Offset = "0x744E690", VA = "0x18744F290")]
	public static FKJPPMMNNEF MNIACJAIICB(this GNENMCIDPEM JPNNGBEFPIE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
internal sealed class KNLCAFBIJKN : EGFCLOFMPEI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private readonly NLAMLALBDFJ GJHPLGMALIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private RigidbodyConstraints APGEKBNINPE;

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public bool HCNFBODKBFP
	{
		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0xA5AAE0", Offset = "0xA59EE0", VA = "0x180A5AAE0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x488D0F0", Offset = "0x488C4F0", VA = "0x18488D0F0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public bool ACDONNIKLPD
	{
		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0xB47430", Offset = "0xB46830", VA = "0x180B47430", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x488D0E0", Offset = "0x488C4E0", VA = "0x18488D0E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public RigidbodyConstraints CCNGDIBBDAG
	{
		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x8AACD0", Offset = "0x8AA0D0", VA = "0x1808AACD0", Slot = "7")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x7459390", Offset = "0x7458790", VA = "0x187459390", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x74594C0", Offset = "0x74588C0", VA = "0x1874594C0")]
	public KNLCAFBIJKN(GNENMCIDPEM GJHPLGMALIK, [In] HBBDMOFMLCI AIKOCCMKKAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x7459330", Offset = "0x7458730", VA = "0x187459330", Slot = "9")]
	public void BMHAAMJPCLN(Rigidbody KLDNEBDEBMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x7459360", Offset = "0x7458760", VA = "0x187459360", Slot = "10")]
	public void GOPOMIDILEH(Rigidbody KLDNEBDEBMN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal sealed class HLHGDDBIOPN : AKKOCMLEJGJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly GNENMCIDPEM GJHPLGMALIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private float MDKLFLDLIGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private float IJEGMGKOCME;

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public float GIIOJNIOBNG
	{
		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0xA2AE70", Offset = "0xA2A270", VA = "0x180A2AE70", Slot = "4")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x74557C0", Offset = "0x7454BC0", VA = "0x1874557C0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public float MKKCJHHNAOG
	{
		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0xB846E0", Offset = "0xB83AE0", VA = "0x180B846E0", Slot = "6")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x74556A0", Offset = "0x7454AA0", VA = "0x1874556A0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x7455930", Offset = "0x7454D30", VA = "0x187455930")]
	public HLHGDDBIOPN(GNENMCIDPEM GJHPLGMALIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x7455770", Offset = "0x7454B70", VA = "0x187455770", Slot = "8")]
	public void BMHAAMJPCLN(Rigidbody KLDNEBDEBMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x7455890", Offset = "0x7454C90", VA = "0x187455890", Slot = "9")]
	public void GOPOMIDILEH(Rigidbody KLDNEBDEBMN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
internal sealed class KCMODJMAJIJ : CJHDOGPCDKJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private readonly NLAMLALBDFJ GJHPLGMALIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private bool FGPBFGIPOJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private bool LHELCMCNNEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private int JPINDNJKION;

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	private Rigidbody KIKAKLALKIE
	{
		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x744E170", Offset = "0x744D570", VA = "0x18744E170")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	private bool BJHHEKDOMOM
	{
		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x74589D0", Offset = "0x7457DD0", VA = "0x1874589D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	private GNENMCIDPEM CNLABKPDMID
	{
		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x7458340", Offset = "0x7457740", VA = "0x187458340")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	private bool GAMAFBGALEN
	{
		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x74585D0", Offset = "0x74579D0", VA = "0x1874585D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002D")]
	public event EIBFAGEEMAF KCEGOHOIJLE
	{
		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x7457F80", Offset = "0x7457380", VA = "0x187457F80", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x7458530", Offset = "0x7457930", VA = "0x187458530", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x74589F0", Offset = "0x7457DF0", VA = "0x1874589F0")]
	public KCMODJMAJIJ(GNENMCIDPEM GJHPLGMALIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x7458940", Offset = "0x7457D40", VA = "0x187458940", Slot = "6")]
	public void OICKCJAMCMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x7458930", Offset = "0x7457D30", VA = "0x187458930", Slot = "8")]
	public void OHMOBPDINJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x74587E0", Offset = "0x7457BE0", VA = "0x1874587E0", Slot = "7")]
	public bool KCNDEMAKNNC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x7458020", Offset = "0x7457420", VA = "0x187458020", Slot = "9")]
	public void DLBLJMIMABA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x74582A0", Offset = "0x74576A0", VA = "0x1874582A0", Slot = "11")]
	public void ENCEEBEJNHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x7458630", Offset = "0x7457A30", VA = "0x187458630", Slot = "10")]
	public void JBKDEAHBDKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x74580C0", Offset = "0x74574C0", VA = "0x1874580C0")]
	private bool EJCHKIGNCEF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x74583A0", Offset = "0x74577A0", VA = "0x1874583A0")]
	private void FMICEPPJKPL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal sealed class KMDAPMPLKFA : DAHLIOGLLCA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private readonly NLAMLALBDFJ GJHPLGMALIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private readonly GDCNMJIEPIF HODKNGLFJEE;

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public Rigidbody KIKAKLALKIE
	{
		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x8A89D0", Offset = "0x8A7DD0", VA = "0x1808A89D0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x8A8A00", Offset = "0x8A7E00", VA = "0x1808A8A00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	private bool GAMAFBGALEN
	{
		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x744A6B0", Offset = "0x7449AB0", VA = "0x18744A6B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public bool GIOGMNMBLBO
	{
		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x11F6010", Offset = "0x11F5410", VA = "0x1811F6010", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x7459220", Offset = "0x7458620", VA = "0x187459220")]
	public KMDAPMPLKFA(GNENMCIDPEM GJHPLGMALIK, [In] HBBDMOFMLCI AIKOCCMKKAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x7459180", Offset = "0x7458580", VA = "0x187459180", Slot = "5")]
	public void OICKCJAMCMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x7458FA0", Offset = "0x74583A0", VA = "0x187458FA0", Slot = "7")]
	public void HNNIKFOPAHB(object ABHFNNFMPHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x7458FD0", Offset = "0x74583D0", VA = "0x187458FD0", Slot = "8")]
	public void LAJLCBGBEBF(object ABHFNNFMPHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x7458C70", Offset = "0x7458070", VA = "0x187458C70", Slot = "9")]
	public void GFONJABDCCI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x7458A80", Offset = "0x7457E80", VA = "0x187458A80", Slot = "10")]
	public void GBBNEFNACOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x7459000", Offset = "0x7458400", VA = "0x187459000", Slot = "11")]
	public void LAMIAPMPKBM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
internal sealed class HEJMACFDPGM : JAPLBFANHGD, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private readonly NLAMLALBDFJ GJHPLGMALIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private readonly GDCNMJIEPIF PIBGLPCECAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private float GKLBIKHMPPN;

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public OPFMAOOBLLA LGKPJBOBGMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0x8AD890", Offset = "0x8ACC90", VA = "0x1808AD890", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0x8AD4B0", Offset = "0x8AC8B0", VA = "0x1808AD4B0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public PAFPNLLDLFP DLCPBKKGFLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(RVA = "0x8AAD10", Offset = "0x8AA110", VA = "0x1808AAD10", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0x8AAD00", Offset = "0x8AA100", VA = "0x1808AAD00", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public Vector3 LAGAIBFOEEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x74533F0", Offset = "0x74527F0", VA = "0x1874533F0", Slot = "8")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0x7452F10", Offset = "0x7452310", VA = "0x187452F10", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public Vector3 BHOHPOALPMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0x74535A0", Offset = "0x74529A0", VA = "0x1874535A0", Slot = "10")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0x7454390", Offset = "0x7453790", VA = "0x187454390", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public Vector3 KNNCHNCILOE
	{
		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0x7453EB0", Offset = "0x74532B0", VA = "0x187453EB0", Slot = "12")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(RVA = "0x7453330", Offset = "0x7452730", VA = "0x187453330", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public Vector3 APBHOELFNPE
	{
		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(RVA = "0x7454200", Offset = "0x7453600", VA = "0x187454200", Slot = "14")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x7452320", Offset = "0x7451720", VA = "0x187452320", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public float MGCHCNEGFHE
	{
		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0xB474A0", Offset = "0xB468A0", VA = "0x180B474A0", Slot = "16")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0x7451D30", Offset = "0x7451130", VA = "0x187451D30", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public bool FMHHHMCOOIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x1B62310", Offset = "0x1B61710", VA = "0x181B62310", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	private ICDBJMBBKCB DGLBMCFFOBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0x6C3FEB0", Offset = "0x6C3F2B0", VA = "0x186C3FEB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	private bool BJHHEKDOMOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0x7455590", Offset = "0x7454990", VA = "0x187455590")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x74555B0", Offset = "0x74549B0", VA = "0x1874555B0")]
	public HEJMACFDPGM(GNENMCIDPEM GJHPLGMALIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x7453800", Offset = "0x7452C00", VA = "0x187453800", Slot = "19")]
	public void OICKCJAMCMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x7452350", Offset = "0x7451750", VA = "0x187452350", Slot = "36")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x7451E40", Offset = "0x7451240", VA = "0x187451E40", Slot = "28")]
	public void BMHAAMJPCLN(Rigidbody KLDNEBDEBMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0xFFED70", Offset = "0xFFE170", VA = "0x180FFED70", Slot = "20")]
	public void PCPFADBGCFB(object ABHFNNFMPHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0xFFECA0", Offset = "0xFFE0A0", VA = "0x180FFECA0", Slot = "30")]
	public void ABCBDPCLGHM(object ABHFNNFMPHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x7452CD0", Offset = "0x74520D0", VA = "0x187452CD0", Slot = "35")]
	public Vector3 EIFFMIENBIO(Vector3 LFFEGBGDOPO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(RVA = "0x7453170", Offset = "0x7452570", VA = "0x187453170", Slot = "34")]
	public Vector3 GIEDGGBOHPA(Vector3 AHELNOLPMIB)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0x7453800", Offset = "0x7452C00", VA = "0x187453800", Slot = "27")]
	public void IJMNINGLFII()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(RVA = "0x7451F70", Offset = "0x7451370", VA = "0x187451F70", Slot = "25")]
	public void CADKCHJHLHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(RVA = "0x7452080", Offset = "0x7451480", VA = "0x187452080", Slot = "24")]
	public void CFNDDLJCEMO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(RVA = "0x74520E0", Offset = "0x74514E0", VA = "0x1874520E0", Slot = "33")]
	public void DJLBKENEHMH(Vector3 FICPNOACCPA, Vector3 MBHKBNFIGNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(RVA = "0x7452EB0", Offset = "0x74522B0", VA = "0x187452EB0", Slot = "32")]
	public void FFAELKNMIGM(Vector3 KFINDPIHPIF, Vector3 GCFMFJNALIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x7454840", Offset = "0x7453C40", VA = "0x187454840", Slot = "31")]
	public void MGOINFGFJOD(Vector3 PCALPEJHEDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x7452630", Offset = "0x7451A30", VA = "0x187452630", Slot = "22")]
	public void EGMKAAINCJN(ECHIOPDOMDO IONCIEEBOBO, Vector3 JOGLJMPKPKH, float PPDEONJIIMA, float OFOGFBIIGGI = 8f, float BJMNFCJBKKE = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x74523B0", Offset = "0x74517B0", VA = "0x1874523B0", Slot = "21")]
	public void EFLEMJFNFOP(ECJJLAKNLID KOCJMOOKFFH, Vector3 BBIPOCPEDJM, float JLDDDBDKMNI = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x74538A0", Offset = "0x7452CA0", VA = "0x1874538A0", Slot = "23")]
	[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
	public void ILEPDKIGMPO(ECJJLAKNLID KOCJMOOKFFH, Vector3 MDJOMEFJFHD, float BBBGCFNLFEE = 7f, float LDHDIPAMOEN = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x1109E50", Offset = "0x1109250", VA = "0x181109E50")]
	private static void DFFCDHEFGIF(Vector3 DLNLPMKHKIC, Vector3 KENGOPLODLD, [Out] Vector3 GDCEKCMIDOH, [Out] Vector3 PHKODCKMLJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x7453720", Offset = "0x7452B20", VA = "0x187453720", Slot = "29")]
	public Vector3 IIPLLEMKFCG(Vector3 DLNLPMKHKIC)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x7454070", Offset = "0x7453470", VA = "0x187454070", Slot = "26")]
	public void JLGHMDCLJFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x7451D30", Offset = "0x7451130", VA = "0x187451D30")]
	private void IMMBAIDCKMJ(float EEPLCHCGAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x7452FD0", Offset = "0x74523D0", VA = "0x187452FD0")]
	private void FKHMCMKEGJC(Vector3 BBIPOCPEDJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x74549E0", Offset = "0x7453DE0", VA = "0x1874549E0")]
	private Vector3 NKKNLFCNIOC()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x7454B60", Offset = "0x7453F60", VA = "0x187454B60")]
	private void NNEBPLDJAEI(Vector3 AHELNOLPMIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x7453D20", Offset = "0x7453120", VA = "0x187453D20")]
	private Vector3 JBABKHBCFGJ()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x74543C0", Offset = "0x74537C0", VA = "0x1874543C0")]
	private void LIBLGCNPGEF(Vector3 EEPLCHCGAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x7454FE0", Offset = "0x74543E0", VA = "0x187454FE0")]
	private void OGMGINBBKLF(Vector3 AHELNOLPMIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x7451FD0", Offset = "0x74513D0", VA = "0x187451FD0")]
	private void CFBJEKPFIAB()
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
