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
using RecRoom.DataLayer.Registration;
using RecRoom.Logging.Attributes;
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
	public class LogRegistrationIndex : EEFEEDICGMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x826AE30", Offset = "0x826A230", VA = "0x18826AE30", Slot = "4")]
		public override void KECNLMAOALC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x9F4500", Offset = "0x9F3900", VA = "0x1809F4500")]
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
			[Cpp2IlInjected.Address(RVA = "0x9C91B0", Offset = "0x9C85B0", VA = "0x1809C91B0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x1FE38C0", Offset = "0x1FE2CC0", VA = "0x181FE38C0", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8277C20", Offset = "0x8277020", VA = "0x188277C20")]
		private void NJKHJLGIPFD(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8277F30", Offset = "0x8277330", VA = "0x188277F30", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8277F90", Offset = "0x8277390", VA = "0x188277F90")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[DisallowMultipleComponent]
	public sealed class RigidbodyEx : MonoBehaviour, GOICLPNEOHK, AHODEOBLEAO, ABEGHIDPNFJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private static readonly LMKAPNBAFDO JCMNBINCDPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private bool PDPDDGEPMJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private GICFIFJOJFH BIBBOGOLIEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		[HJIOCNMHEJP(ANEAJGIOFML.Self, false, false, false)]
		[SerializeField]
		private Rigidbody unityRigidbody;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[SerializeField]
		[HJIOCNMHEJP(ANEAJGIOFML.SelfAndParent, true, false, false)]
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
		private GPDLPHADFJO physicsInterpolation;

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
		private Transform DBIIEMKDJHO;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		internal GICFIFJOJFH CLNJNKIAKKK
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x8273BE0", Offset = "0x8272FE0", VA = "0x188273BE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private GICFIFJOJFH IODBPJMCAOD
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x9CFD20", Offset = "0x9CF120", VA = "0x1809CFD20", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public int NJFOMMDGDBB
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x82750F0", Offset = "0x82744F0", VA = "0x1882750F0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public RigidbodyEx CIHIDGKLMLB
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x8275450", Offset = "0x8274850", VA = "0x188275450")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public RigidbodyEx IAKDDPPLCKG
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x8275390", Offset = "0x8274790", VA = "0x188275390")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public RigidbodyEx GEFLCBDBKHP
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x8276060", Offset = "0x8275460", VA = "0x188276060")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x8277590", Offset = "0x8276990", VA = "0x188277590")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool HFNAFNGMPCD
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x7ED9110", Offset = "0x7ED8510", VA = "0x187ED9110", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x7EDBE00", Offset = "0x7EDB200", VA = "0x187EDBE00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public Transform NIBJBBEPHBE
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x1E181E0", Offset = "0x1E175E0", VA = "0x181E181E0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Transform CGODNFAPFMJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x1E181E0", Offset = "0x1E175E0", VA = "0x181E181E0", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public Transform PKKOLONGCCG
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x1E181E0", Offset = "0x1E175E0", VA = "0x181E181E0", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public OJCAHADJONK GADINEIPPPC
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x8275150", Offset = "0x8274550", VA = "0x188275150")]
			get
			{
				return default(OJCAHADJONK);
			}
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x8276D40", Offset = "0x8276140", VA = "0x188276D40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public bool PPPIDLACBDJ
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x8275760", Offset = "0x8274B60", VA = "0x188275760")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public bool GODGINKKHJC
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x8275270", Offset = "0x8274670", VA = "0x188275270")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public AIBIADFLBPK NMAHICPLDKA
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x82756A0", Offset = "0x8274AA0", VA = "0x1882756A0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x8276F00", Offset = "0x8276300", VA = "0x188276F00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public DJGGIEMJFKA IIGGFPNAGBB
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x8275640", Offset = "0x8274A40", VA = "0x188275640")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x8276E90", Offset = "0x8276290", VA = "0x188276E90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool OINDCDNLCJH
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x8275590", Offset = "0x8274990", VA = "0x188275590")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public Rigidbody AOPHMJNJAKE
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x82755F0", Offset = "0x82749F0", VA = "0x1882755F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool GLHMNBANGDL
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x82752D0", Offset = "0x82746D0", VA = "0x1882752D0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x8276DB0", Offset = "0x82761B0", VA = "0x188276DB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public bool LACHFIGDDCL
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x1530CA0", Offset = "0x15300A0", VA = "0x181530CA0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public float JPAJIDFLKFC
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x8276000", Offset = "0x8275400", VA = "0x188276000")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public float NAFPEBPFOHG
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x8275FA0", Offset = "0x82753A0", VA = "0x188275FA0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x8277520", Offset = "0x8276920", VA = "0x188277520")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public float HEKBEHMEPEJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x82759C0", Offset = "0x8274DC0", VA = "0x1882759C0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x82771A0", Offset = "0x82765A0", VA = "0x1882771A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public float IHAJIBMNICB
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x82757C0", Offset = "0x8274BC0", VA = "0x1882757C0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x8276F70", Offset = "0x8276370", VA = "0x188276F70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public bool EMFDEDEPGAC
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x82765E0", Offset = "0x82759E0", VA = "0x1882765E0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x8277AD0", Offset = "0x8276ED0", VA = "0x188277AD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public Vector3 FFIEBDNIHIK
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x8275D80", Offset = "0x8275180", VA = "0x188275D80")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x82772F0", Offset = "0x82766F0", VA = "0x1882772F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public Vector3 GNDGJHEAGOA
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x8276720", Offset = "0x8275B20", VA = "0x188276720")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public CollisionDetectionMode JDDNBNMNAAI
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x8275900", Offset = "0x8274D00", VA = "0x188275900")]
			get
			{
				return default(CollisionDetectionMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x82770C0", Offset = "0x82764C0", VA = "0x1882770C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public float IPPOJNBGJAI
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x8275330", Offset = "0x8274730", VA = "0x188275330")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x8276E20", Offset = "0x8276220", VA = "0x188276E20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public RigidbodyConstraints DPGBGNIJCOG
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x8275960", Offset = "0x8274D60", VA = "0x188275960")]
			get
			{
				return default(RigidbodyConstraints);
			}
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x8277130", Offset = "0x8276530", VA = "0x188277130")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public Vector3 FHINFOBEPGH
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x8276120", Offset = "0x8275520", VA = "0x188276120")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public Vector3 BIKBOOBIAKE
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x8276120", Offset = "0x8275520", VA = "0x188276120")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x82778B0", Offset = "0x8276CB0", VA = "0x1882778B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public float BBKFIAGCKKH
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x8275E60", Offset = "0x8275260", VA = "0x188275E60")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x82773D0", Offset = "0x82767D0", VA = "0x1882773D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public float GGGILIDLMCK
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x8276580", Offset = "0x8275980", VA = "0x188276580")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x8277A60", Offset = "0x8276E60", VA = "0x188277A60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public Quaternion MOMMGMAKELF
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x8276200", Offset = "0x8275600", VA = "0x188276200")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x8277630", Offset = "0x8276A30", VA = "0x188277630")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public Quaternion BDNPFELCEHA
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x82764A0", Offset = "0x82758A0", VA = "0x1882764A0")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x8277990", Offset = "0x8276D90", VA = "0x188277990")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public Vector3 EHIOBEDOGIB
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x82762E0", Offset = "0x82756E0", VA = "0x1882762E0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x8277700", Offset = "0x8276B00", VA = "0x188277700")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public Quaternion CGNJMOGGBJE
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x82763C0", Offset = "0x82757C0", VA = "0x1882763C0")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x82777E0", Offset = "0x8276BE0", VA = "0x1882777E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public Vector3 GEIOPELMCBI
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x8276640", Offset = "0x8275A40", VA = "0x188276640")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x8277B40", Offset = "0x8276F40", VA = "0x188277B40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public Vector3 HHLKLFCBGLL
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x8275EC0", Offset = "0x82752C0", VA = "0x188275EC0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x8277440", Offset = "0x8276840", VA = "0x188277440")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Vector3 EDKDJJNNIFC
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x8275820", Offset = "0x8274C20", VA = "0x188275820")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x8276FE0", Offset = "0x82763E0", VA = "0x188276FE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public Vector3 MMINKAKFLHH
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x8275CA0", Offset = "0x82750A0", VA = "0x188275CA0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x8277210", Offset = "0x8276610", VA = "0x188277210")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public Vector3 HPJNAEPAFBI
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x8275B60", Offset = "0x8274F60", VA = "0x188275B60")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public Quaternion GPBCOCAGLFE
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x8275A80", Offset = "0x8274E80", VA = "0x188275A80")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public Vector3 JDNBHELIGDO
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x82768E0", Offset = "0x8275CE0", VA = "0x1882768E0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public Vector3 FCFEAHPLKFM
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x8276800", Offset = "0x8275C00", VA = "0x188276800")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool KDDPMILKDKB
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x8275C40", Offset = "0x8275040", VA = "0x188275C40")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool LNPODHPPPLB
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x8275700", Offset = "0x8274B00", VA = "0x188275700")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public bool NBPLILMEDJF
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x8275210", Offset = "0x8274610", VA = "0x188275210")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public bool HHEFAEPGCEG
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x82751B0", Offset = "0x82745B0", VA = "0x1882751B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public bool DMHOGJNEKLE
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x8275090", Offset = "0x8274490", VA = "0x188275090")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public bool CGIHAHNALJF
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x8275A20", Offset = "0x8274E20", VA = "0x188275A20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public bool PJBCMDOMBND
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x22DD620", Offset = "0x22DCA20", VA = "0x1822DD620")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event OACFBICGIID EONJDHJONCM
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x8274FB0", Offset = "0x82743B0", VA = "0x188274FB0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x8276C60", Offset = "0x8276060", VA = "0x188276C60")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event HKGADDNGDGE FCONDJGCOBI
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x8274D20", Offset = "0x8274120", VA = "0x188274D20")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x82769C0", Offset = "0x8275DC0", VA = "0x1882769C0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event HKGADDNGDGE KPEEKMGJIGD
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x8274D80", Offset = "0x8274180", VA = "0x188274D80")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x8276A30", Offset = "0x8275E30", VA = "0x188276A30")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event HKGADDNGDGE JIGPGNBHBAB
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x8274ED0", Offset = "0x82742D0", VA = "0x188274ED0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x8276B80", Offset = "0x8275F80", VA = "0x188276B80")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action<BAJKLLBGNIN, BAJKLLBGNIN> HOGOLDMCGIP
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x8274E60", Offset = "0x8274260", VA = "0x188274E60")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x8276B10", Offset = "0x8275F10", VA = "0x188276B10")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event HKGADDNGDGE EPAGKHGFOAI
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x8274F40", Offset = "0x8274340", VA = "0x188274F40")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x8276BF0", Offset = "0x8275FF0", VA = "0x188276BF0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event HKGADDNGDGE CPBJEAPHBLI
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x8275020", Offset = "0x8274420", VA = "0x188275020")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x8276CD0", Offset = "0x82760D0", VA = "0x188276CD0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event HKGADDNGDGE ONHAHNFKGGI
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x8274DF0", Offset = "0x82741F0", VA = "0x188274DF0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x8276AA0", Offset = "0x8275EA0", VA = "0x188276AA0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x9CCC50", Offset = "0x9CC050", VA = "0x1809CCC50", Slot = "8")]
		private void ENJGDMNGPJF(GICFIFJOJFH GDOONENKGAE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x8273770", Offset = "0x8272B70", VA = "0x188273770", Slot = "9")]
		public ADADNNBAMPN GetData()
		{
			return default(ADADNNBAMPN);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x8273250", Offset = "0x8272650", VA = "0x188273250")]
		internal void BJKDLHLPPFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8274A40", Offset = "0x8273E40", VA = "0x188274A40")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		public void TestOverrideUnityRigidbody(Rigidbody IINCAHENAGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x82734C0", Offset = "0x82728C0", VA = "0x1882734C0")]
		public GOICLPNEOHK GetChild(int COPLIEINKOF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x8274700", Offset = "0x8273B00", VA = "0x188274700")]
		public void SetInertiaTensor((Quaternion rot, Vector3 moments) CADPOCIBAEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x8273080", Offset = "0x8272480", VA = "0x188273080")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x8274990", Offset = "0x8273D90", VA = "0x188274990")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x8273BE0", Offset = "0x8272FE0", VA = "0x188273BE0")]
		private GICFIFJOJFH JNLMMENAEEG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x8273800", Offset = "0x8272C00", VA = "0x188273800")]
		private void HGEPFBBIJLL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x8273EC0", Offset = "0x82732C0", VA = "0x188273EC0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x8273E00", Offset = "0x8273200", VA = "0x188273E00")]
		public void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x8273250", Offset = "0x8272650", VA = "0x188273250")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x8273E60", Offset = "0x8273260", VA = "0x188273E60")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x8273F20", Offset = "0x8273320", VA = "0x188273F20")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x8272730", Offset = "0x8271B30", VA = "0x188272730")]
		public void AddDoNotResetVelocityOnOwnershipChangeOverride(object PAHPIGHLKFG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x8273F90", Offset = "0x8273390", VA = "0x188273F90")]
		public void RemoveDoNotResetVelocityOnOwnershipChangeOverride(object PAHPIGHLKFG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x8273460", Offset = "0x8272860", VA = "0x188273460")]
		public void DisableCachedInertialPropertyOverride()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x8273DA0", Offset = "0x82731A0", VA = "0x188273DA0")]
		public void MarkCachedInertialParametersDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x8274860", Offset = "0x8273C60", VA = "0x188274860")]
		public void SetParent(RigidbodyEx OOEMJLHLIHJ, bool LPODAIKDKIP = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x82742A0", Offset = "0x82736A0", VA = "0x1882742A0")]
		public void ResetLocalCenterOfMassToPrefabDefault()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x8273980", Offset = "0x8272D80", VA = "0x188273980")]
		public bool IsRigidbodyAncestor(RigidbodyEx BAJGMJFJAMA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x8273A80", Offset = "0x8272E80", VA = "0x188273A80")]
		public bool IsRigidbodyDescendant(RigidbodyEx FAOIHHNBFMJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x82729A0", Offset = "0x8271DA0", VA = "0x1882729A0")]
		public void AddInterpolationRestriction(object PAHPIGHLKFG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x8274000", Offset = "0x8273400", VA = "0x188274000")]
		public void RemoveInterpolationRestriction(object PAHPIGHLKFG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x8272A10", Offset = "0x8271E10", VA = "0x188272A10")]
		public void AddKinematic(object PAHPIGHLKFG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x8274070", Offset = "0x8273470", VA = "0x188274070")]
		public void RemoveKinematic(object PAHPIGHLKFG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x82747E0", Offset = "0x8273BE0", VA = "0x1882747E0")]
		public void SetKinematic(object PAHPIGHLKFG, bool IJHBPMOJNME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x8274600", Offset = "0x8273A00", VA = "0x188274600")]
		public void SetDiscontinuousPositionAndRotation(Vector3 LGBGLNCCKJC, Quaternion NGBFEBOBFHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x8274500", Offset = "0x8273900", VA = "0x188274500")]
		public void SetDiscontinuousLocalPositionAndLocalRotation(Vector3 LFFOIEKCJLE, Quaternion IFPAFJMCLFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x8273660", Offset = "0x8272A60", VA = "0x188273660")]
		public Vector3 GetConstrainedVelocity(Vector3 GEIOPELMCBI)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x8273550", Offset = "0x8272950", VA = "0x188273550")]
		public Vector3 GetConstrainedAngularVelocity(Vector3 EDKDJJNNIFC)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x82728B0", Offset = "0x8271CB0", VA = "0x1882728B0")]
		public void AddForce(Vector3 IMJBLFBLNHJ, ForceMode IPMAPBMKNFL = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x82727A0", Offset = "0x8271BA0", VA = "0x1882727A0")]
		public void AddForceAtPosition(Vector3 IMJBLFBLNHJ, Vector3 KBPOHLLNAIG, ForceMode IPMAPBMKNFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x8272BE0", Offset = "0x8271FE0", VA = "0x188272BE0")]
		public void AddTorque(Vector3 HAJDLEHAPNN, ForceMode IPMAPBMKNFL = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x8272A80", Offset = "0x8271E80", VA = "0x188272A80")]
		public void AddRelativeTorque(Vector3 HAJDLEHAPNN, ForceMode IPMAPBMKNFL = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x8274B10", Offset = "0x8273F10", VA = "0x188274B10")]
		public Vector3 WorldToLocalVelocity(Vector3 AOBMGFHHGEN)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x8273C90", Offset = "0x8273090", VA = "0x188273C90")]
		public Vector3 LocalToWorldVelocity(Vector3 HHLKLFCBGLL)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x8273400", Offset = "0x8272800", VA = "0x188273400")]
		public void ClearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x82733A0", Offset = "0x82727A0", VA = "0x1882733A0")]
		public void ClearUnityRigidbodyVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x8273340", Offset = "0x8272740", VA = "0x188273340")]
		public void ClearLinearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x82732E0", Offset = "0x82726E0", VA = "0x1882732E0")]
		public void ClearAngularVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x8274400", Offset = "0x8273800", VA = "0x188274400")]
		public void ResetVelocityWorldSpace(Vector3 PIFIIAMNLNN, Vector3 JBJBDCBDBHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x8274300", Offset = "0x8273700", VA = "0x188274300")]
		public void ResetVelocityLocalSpace(Vector3 BKGONMDOKLB, Vector3 MMINKAKFLHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x82741C0", Offset = "0x82735C0", VA = "0x1882741C0")]
		public void ResetLinearVelocityLocalSpace(Vector3 BKGONMDOKLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x82749A0", Offset = "0x8273DA0", VA = "0x1882749A0")]
		public bool SweepTest(Vector3 DJMLEJBBDGG, [Out] RaycastHit LAJGANGDPIC, float IJIIMBMEDNE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x8273B80", Offset = "0x8272F80", VA = "0x188273B80")]
		public bool IsSleeping()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x8274930", Offset = "0x8273D30", VA = "0x188274930")]
		public void Sleep()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x8274AB0", Offset = "0x8273EB0", VA = "0x188274AB0")]
		public void WakeUp()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x8272B70", Offset = "0x8271F70", VA = "0x188272B70")]
		public void AddShouldHaveUnityRigidbodyToken(object PAHPIGHLKFG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x82740E0", Offset = "0x82734E0", VA = "0x1882740E0")]
		public void RemoveShouldHaveUnityRigidbodyToken(object PAHPIGHLKFG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x8272F10", Offset = "0x8272310", VA = "0x188272F10")]
		public void ApplyForceVelocityChange(ACECPJNBPEC JIEFFOKJFPC, Vector3 OCHOJDMGPFE, float DCPCCMFADCM, float KCNBDGLKJNH = 8f, float FAJHCHFJGPO = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x8272E70", Offset = "0x8272270", VA = "0x188272E70")]
		public void ApplyAngularVelocityChange(IICCECNKAHL OEKEAMNGPPI, Vector3 LGKODENCBAE, float EACAFMBIMBN = float.PositiveInfinity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x8272FD0", Offset = "0x82723D0", VA = "0x188272FD0")]
		[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
		public void ApplyTorqueAngularVelocityChangeDeprecated(IICCECNKAHL OEKEAMNGPPI, Vector3 PNEDBEMJDJJ, float EMALLGBKLKM = 7f, float FODFJNNAENB = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x8272DA0", Offset = "0x82721A0", VA = "0x188272DA0")]
		public bool AllowedScaleChange(float BIPFCDNOGAF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x8272CD0", Offset = "0x82720D0", VA = "0x188272CD0")]
		public void AddWorldSpaceVelocityInHierarchyParentOverride(RigidbodyEx MGECHFICKLL, object PAHPIGHLKFG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x8274150", Offset = "0x8273550", VA = "0x188274150")]
		public void RemoveWorldSpaceVelocityInHierarchyParentOverride(object PAHPIGHLKFG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x8273F80", Offset = "0x8273380", VA = "0x188273F80", Slot = "12")]
		private void POMIMJJFNOI(NCJHHPABBJL FAJBNOJIOHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x8274CB0", Offset = "0x82740B0", VA = "0x188274CB0")]
		public RigidbodyEx()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0xB67EE0", Offset = "0xB672E0", VA = "0x180B67EE0", Slot = "4")]
		private GameObject DBOMCCOGMEN()
		{
			return null;
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x9F69F0", Offset = "0x9F5DF0", VA = "0x1809F69F0", Slot = "10")]
		private bool LDCBNFHEIEE()
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
internal static class BHBFCLIIPPB
{
	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x825C9F0", Offset = "0x825BDF0", VA = "0x18825C9F0")]
	public static GICFIFJOJFH CLNJNKIAKKK(this RigidbodyEx HPGKJPCLFAN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[RegisterService(typeof(BNNCIAIELHF), new string[] { })]
public class FIBFHLAJPED : BNNCIAIELHF, JFNILPFMLLH
{
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static readonly LMKAPNBAFDO KIBGFJNEFGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private OJFCGGADJCB HLIKBEKBJPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private DBCHOEAKDFA KNFKPOHGHBC;

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public OJFCGGADJCB GHCAPJHEIJG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x9C9460", Offset = "0x9C8860", VA = "0x1809C9460", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public DBCHOEAKDFA DJDENOJBJFF
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x9C9200", Offset = "0x9C8600", VA = "0x1809C9200", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x825D9A0", Offset = "0x825CDA0", VA = "0x18825D9A0", Slot = "7")]
	public void InitReferences(KKNBMHIKNAE GDLAIBAPFED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x825D870", Offset = "0x825CC70", VA = "0x18825D870", Slot = "6")]
	public GICFIFJOJFH IOMGDCADJCE(RigidbodyEx HPGKJPCLFAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
	public FIBFHLAJPED()
	{
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class PhysicsManager : SingletonMonoBehaviour<PhysicsManager>
	{
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public static KFBDEOPEKLE UpdateAfterFixedUpdateRan;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private int KMPBLEJPBHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private int MNNGKOOCEPE;

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x8272590", Offset = "0x8271990", VA = "0x188272590")]
		protected void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x82725D0", Offset = "0x82719D0", VA = "0x1882725D0")]
		protected void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x82725B0", Offset = "0x82719B0", VA = "0x1882725B0")]
		protected void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsNotYetUpdated([Optional] string FGEBHLNNMNH, [Optional] UnityEngine.Object FAJBNOJIOHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsAlreadyUpdated([Optional] string FGEBHLNNMNH, [Optional] UnityEngine.Object FAJBNOJIOHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x82726E0", Offset = "0x8271AE0", VA = "0x1882726E0")]
		public PhysicsManager()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class PHFAAAJCGIC
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private class JFCNHLLNONL : AIBIADFLBPK, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230", Slot = "7")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x9DAA10", Offset = "0x9D9E10", VA = "0x1809DAA10", Slot = "4")]
		public Vector3 FEPNGBHMJCB()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x9DAA10", Offset = "0x9D9E10", VA = "0x1809DAA10", Slot = "5")]
		public Vector3 CFEAFBNKCEG()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x9E54A0", Offset = "0x9E48A0", VA = "0x1809E54A0", Slot = "6")]
		public bool MDACLAHJPEP(float HJNODIKKFJL, float IBGLCDHAONI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
		public JFCNHLLNONL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public static AIBIADFLBPK FHCGFKLLPJF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x82724C0", Offset = "0x82718C0", VA = "0x1882724C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface DDJPOLGNLCC
{
	[Cpp2IlInjected.Token(Token = "0x17000039")]
	CollisionDetectionMode HKGNPADLCEP
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
	void GNGOBIJMNKI();

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void DDHKONLMDKA(bool KDDPMILKDKB);

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void BODMAKHENJM(bool KDDPMILKDKB);

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void ICPNPHDEPFL(Rigidbody DKBIBNDFCGL);

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool CHAMOAHNAFL(Vector3 DJMLEJBBDGG, [Out] RaycastHit LAJGANGDPIC, float IJIIMBMEDNE);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface CHHHPFDIIAH : IDisposable, ADBBNFIBLNJ
{
	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	OJCAHADJONK GADINEIPPPC
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event Action<BAJKLLBGNIN, BAJKLLBGNIN> HOGOLDMCGIP;

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void GNGOBIJMNKI();
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[ServiceLifetime(Lifetime.Application)]
public interface DBCHOEAKDFA
{
	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	PAMIPDFOPBD FHFMPNBPPIK(GICFIFJOJFH GDOONENKGAE);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	JCPGEPDHKEO DCHIODDDEKO(GICFIFJOJFH GDOONENKGAE);

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	EACHHLKHPFC EEJIKAKPCPC(GICFIFJOJFH GDOONENKGAE);

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "3")]
	JMFCOKPIFND EHHJDJNPHLK(GICFIFJOJFH GDOONENKGAE);

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "4")]
	HDGJLLMIFGG FHLNDNDMMLE(GICFIFJOJFH GDOONENKGAE);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "5")]
	CHHHPFDIIAH KNMJKOOAKBJ(GICFIFJOJFH GDOONENKGAE);

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "6")]
	MKHHEKNABIG HIPIPPDMIKP(GICFIFJOJFH GDOONENKGAE);

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "7")]
	DBFNPAONDKN HDKIEEFLOFJ(GICFIFJOJFH GDOONENKGAE);

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(Slot = "8")]
	DDJPOLGNLCC KCCNBDOBKCK(GICFIFJOJFH GDOONENKGAE);

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(Slot = "9")]
	KOHILGOLKPK LJKFKCPANEA(GICFIFJOJFH GDOONENKGAE);

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(Slot = "10")]
	HCIMJBHHCBB AIECANMENOP(GICFIFJOJFH GDOONENKGAE, [In] ADADNNBAMPN AOFGGGKINCN);

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "11")]
	DNLKHBAOIHE NJKDKIBBMGN(GICFIFJOJFH GDOONENKGAE, [In] ADADNNBAMPN AOFGGGKINCN);

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "12")]
	HCBFIFNJKMF DDFOIFJMCLJ(GICFIFJOJFH GDOONENKGAE, [In] ADADNNBAMPN AOFGGGKINCN);

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "13")]
	OGNAHMKFMMK DNFNJJIJDBG(GICFIFJOJFH GDOONENKGAE, [In] ADADNNBAMPN AOFGGGKINCN);

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "14")]
	IEMDINAOHOM ANJLLNLKNPF(GICFIFJOJFH GDOONENKGAE, [In] ADADNNBAMPN AOFGGGKINCN);

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "15")]
	GICFIFJOJFH IOMGDCADJCE(RigidbodyEx HPGKJPCLFAN, ADADNNBAMPN AOFGGGKINCN, BNNCIAIELHF BIGODBDFGBM);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface DBFNPAONDKN
{
	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NIDHOAOHIMA(Vector3 IMJBLFBLNHJ, ForceMode IPMAPBMKNFL = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EHHALGMHHCB(Vector3 IMJBLFBLNHJ, Vector3 KBPOHLLNAIG, ForceMode IPMAPBMKNFL);

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LOJBAAEOHAN(Vector3 HAJDLEHAPNN, ForceMode IPMAPBMKNFL = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void AONNKIKMNDI(Vector3 HAJDLEHAPNN, ForceMode IPMAPBMKNFL = ForceMode.Force);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface KOHILGOLKPK
{
	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	bool AOEDEHHIACP
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
	void ICPNPHDEPFL(Rigidbody DKBIBNDFCGL);

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NDPHAMPHODD(Rigidbody DKBIBNDFCGL);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface PAMIPDFOPBD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	IReadOnlyList<GICFIFJOJFH> EPNACLIAFPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	GICFIFJOJFH IAKDDPPLCKG
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	GICFIFJOJFH KCNKMLOKLAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(Slot = "21")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event HKGADDNGDGE FCONDJGCOBI;

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event HKGADDNGDGE KPEEKMGJIGD;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event OACFBICGIID IANGJMELBFM;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action EBDJHEIJEAB;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event Action CJGIDBPLCHF;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	event Action<GICFIFJOJFH> OGKIIPBDKCM;

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event Action<GICFIFJOJFH> PFOMNGJHGMD;

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	event Action PLGINMLHMHN;

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	event Action<GICFIFJOJFH> NBNOKGKFLFG;

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void DNHIHCOJECG(GICFIFJOJFH EEKCDPNNHKN, bool LPODAIKDKIP = false);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface EACHHLKHPFC
{
	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	Vector3 HJDIAKGGDKO
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	Vector3 FDIMBJIKAKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JCOIPKGHBPI(GICFIFJOJFH GEFLCBDBKHP, object PAHPIGHLKFG);

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void EACFAJMOAEG(object PAHPIGHLKFG);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface OGNAHMKFMMK
{
	[Cpp2IlInjected.Token(Token = "0x17000041")]
	Vector3 FDDCDPJLIHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	Vector3 GLPJNAEIHNP
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	float HBCFNHKMNPO
	{
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	float DNOMNDNMNPP
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	Vector3 FDIHCFCMBDM
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	Quaternion HFGLICCCKGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	event HKGADDNGDGE POBAPENBDHP;

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void KGCBONACHIJ((Quaternion rot, Vector3 moments) CADPOCIBAEJ);

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void PMFMAHKOJNJ();

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void GPBGPFKDBDA();

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void ODFGKKENEFC();

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void ICPNPHDEPFL(Rigidbody DKBIBNDFCGL);

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void NDPHAMPHODD(Rigidbody DKBIBNDFCGL);

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void PFOGNJACKCN();
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface HCBFIFNJKMF
{
	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GNGOBIJMNKI();

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CAKNFHDNAPC(object PAHPIGHLKFG);

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void EADFFCPFEIG(object PAHPIGHLKFG);

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void ILHKFHINLAA(GICFIFJOJFH HPGKJPCLFAN);

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void LFMLFBJGKCL(GICFIFJOJFH HPGKJPCLFAN);

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void LHFOCCLPOCB();
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface MKHHEKNABIG
{
	[Cpp2IlInjected.Token(Token = "0x17000047")]
	bool JINBBHINGPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	event HKGADDNGDGE BFNHICKBAHI;

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void CKGJKLBKKKG(object PAHPIGHLKFG);

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void PKCBLKKEDBN(object PAHPIGHLKFG);

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void HCBBCKMJEDI(object PAHPIGHLKFG, bool IJHBPMOJNME);

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void ICPNPHDEPFL(Rigidbody HHPFGDJAMCG);

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void NDPHAMPHODD(Rigidbody DKBIBNDFCGL);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface DNLKHBAOIHE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000048")]
	bool PPPIDLACBDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	bool GODGINKKHJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	event HKGADDNGDGE PLDPKJPPFGE;

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void GNGOBIJMNKI();

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void ABBBDEDONGK(GICFIFJOJFH GEFLCBDBKHP);

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void EOAOFNLOHPL(GICFIFJOJFH GEFLCBDBKHP);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface IEMDINAOHOM
{
	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	bool GLHMNBANGDL
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	bool EOFFNKDIBDE
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	RigidbodyConstraints PNAJJJHMEJC
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
	void ICPNPHDEPFL(Rigidbody DKBIBNDFCGL);

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void NDPHAMPHODD(Rigidbody DKBIBNDFCGL);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface JMFCOKPIFND
{
	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	float KMAADDJCFLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	float ELIFMPDAEKP
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
	void ICPNPHDEPFL(Rigidbody DKBIBNDFCGL);

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void NDPHAMPHODD(Rigidbody DKBIBNDFCGL);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface HDGJLLMIFGG
{
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	static bool FNAACBHOIAF;

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	event HKGADDNGDGE DFBGBPDOIJE;

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GNGOBIJMNKI();

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool MCMHMADGEPP();

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void KIEFKPCKNHN();

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void DAKDHECJMED();

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool ABNDODAJOFC();

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool PLCGOJGJFDG();

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void IBCEDLBGDLN(bool NIIFBEGBKJA);

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void HPCDKCEBBJO();
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface HCIMJBHHCBB
{
	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	Rigidbody AOPHMJNJAKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	bool KLGPNIKIJCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GNGOBIJMNKI();

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void IJOGEMIEIEO(object PAHPIGHLKFG);

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void MAGFMILKOFI(object PAHPIGHLKFG);

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void DKBIHBCABGI();
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface JCPGEPDHKEO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000051")]
	AIBIADFLBPK NMAHICPLDKA
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	DJGGIEMJFKA IIGGFPNAGBB
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	Vector3 FNIBKHAODCL
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	Vector3 ANICHLGAPOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	Vector3 CCENGJCDCIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	Vector3 NIMGIDAKOEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	float IPPOJNBGJAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	bool OINDCDNLCJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void GNGOBIJMNKI();

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void MCONLBHNHCA(object PAHPIGHLKFG);

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void OGJEHMOPEFB(IICCECNKAHL OEKEAMNGPPI, Vector3 LGKODENCBAE, float EACAFMBIMBN = float.PositiveInfinity);

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void AMHAKPNCFDH(ACECPJNBPEC JIEFFOKJFPC, Vector3 OCHOJDMGPFE, float DCPCCMFADCM, float KCNBDGLKJNH = 8f, float FAJHCHFJGPO = 1f);

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void CDINKAONFNP(IICCECNKAHL OEKEAMNGPPI, Vector3 PNEDBEMJDJJ, float EMALLGBKLKM = 7f, float FODFJNNAENB = 1f);

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void LGDDICODLPH();

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void GMBBGNAIGNH();

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void NPMBLMCMJII();

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void LKFAACLOCGG();

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void ICPNPHDEPFL(Rigidbody DKBIBNDFCGL);

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(Slot = "25")]
	Vector3 LFLGNCMPGPB(Vector3 GEIOPELMCBI);

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void EHJGKDLOAGA(object PAHPIGHLKFG);

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void HLIKJFMNOKC(Vector3 AELCMMAJOPJ);

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void CJFAGBJBHIK(Vector3 BKGONMDOKLB, Vector3 MMINKAKFLHH);

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void FNKJCMLNOEK(Vector3 PIFIIAMNLNN, Vector3 JBJBDCBDBHN);

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(Slot = "30")]
	Vector3 LLIEJOIKFEB(Vector3 HHLKLFCBGLL);

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(Slot = "31")]
	Vector3 MNPAKKLLLPG(Vector3 AOBMGFHHGEN);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[ServiceLifetime(Lifetime.Application)]
public interface OJFCGGADJCB
{
	[Cpp2IlInjected.Token(Token = "0x17000059")]
	bool OELEDMKMMIG
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BOICCLOMOFC(string MHFONFLBJOA);

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GHCIAAEPNAB(RigidbodyEx HPGKJPCLFAN, Action PDHMHKIHKPF);

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	APLIPBJIGME GOAELHIOEJO(int MOLFAPIBBHG);

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void LKNDDOFINOH(Vector3 GNDGJHEAGOA, float LGFEMBBGPIC, Color JLFKDHGAEDA);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[ServiceLifetime(Lifetime.Application)]
public interface BNNCIAIELHF
{
	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	OJFCGGADJCB GHCAPJHEIJG
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	DBCHOEAKDFA DJDENOJBJFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(Slot = "2")]
	GICFIFJOJFH IOMGDCADJCE(RigidbodyEx HPGKJPCLFAN);
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class JDPJNFAEJIG : GICFIFJOJFH, IDisposable, EPNFHNPKPOI
{
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public static bool GNJBBBJBPGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	internal readonly BNNCIAIELHF BIGODBDFGBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	internal PAMIPDFOPBD JINJFHIHLGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	internal HCBFIFNJKMF PJGPJFGFGIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	internal DNLKHBAOIHE OLLPMBMHEHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	internal JCPGEPDHKEO GEIOPELMCBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	internal EACHHLKHPFC MGCPLFLGBGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	internal OGNAHMKFMMK FGCKNBLOOFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	internal JMFCOKPIFND BFDPJDMEPLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	internal KOHILGOLKPK FFAEBNLMBPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	internal HDGJLLMIFGG LGIHEEOKGNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	internal CHHHPFDIIAH NABMGLAFALF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	internal MKHHEKNABIG HGAMBCLMJDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	internal DBFNPAONDKN IMJBLFBLNHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	internal IEMDINAOHOM OHGGLGEHANL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	internal HCIMJBHHCBB DKBIBNDFCGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	internal DDJPOLGNLCC LALBBLIBPCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	internal IDisposable BLCAGPJMJOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private bool AMMENDNLENE;

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public NLJNHNAFJHN NMHFPEJCKLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x9CB240", Offset = "0x9CA640", VA = "0x1809CB240", Slot = "22")]
		get
		{
			return default(NLJNHNAFJHN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public GOICLPNEOHK EHBMIAGICKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0xC9B070", Offset = "0xC9A470", VA = "0x180C9B070", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0xE0CC00", Offset = "0xE0C000", VA = "0x180E0CC00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public GameObject BNJNOHCALEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E60", Offset = "0x9D3260", VA = "0x1809D3E60", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x9D3EC0", Offset = "0x9D32C0", VA = "0x1809D3EC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public Transform ACIFLJLGGLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0xBE6830", Offset = "0xBE5C30", VA = "0x180BE6830", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0xE18B10", Offset = "0xE17F10", VA = "0x180E18B10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public Rigidbody AOPHMJNJAKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x8264F90", Offset = "0x8264390", VA = "0x188264F90", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public GICFIFJOJFH KCNKMLOKLAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x8262AE0", Offset = "0x8261EE0", VA = "0x188262AE0", Slot = "27")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x8265630", Offset = "0x8264A30", VA = "0x188265630", Slot = "28")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public int NJFOMMDGDBB
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x8264620", Offset = "0x8263A20", VA = "0x188264620", Slot = "31")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public GICFIFJOJFH IAKDDPPLCKG
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x8264FE0", Offset = "0x82643E0", VA = "0x188264FE0", Slot = "29")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public bool MEPLBDGGGJF
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x8266C60", Offset = "0x8266060", VA = "0x188266C60", Slot = "32")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public bool PPPIDLACBDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x8263190", Offset = "0x8262590", VA = "0x188263190", Slot = "33")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public bool GODGINKKHJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x82632A0", Offset = "0x82626A0", VA = "0x1882632A0", Slot = "34")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public AIBIADFLBPK NMAHICPLDKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x8267330", Offset = "0x8266730", VA = "0x188267330", Slot = "35")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x82675B0", Offset = "0x82669B0", VA = "0x1882675B0", Slot = "36")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public DJGGIEMJFKA IIGGFPNAGBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x8263CD0", Offset = "0x82630D0", VA = "0x188263CD0", Slot = "37")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x8265920", Offset = "0x8264D20", VA = "0x188265920", Slot = "38")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public float IPPOJNBGJAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x8263250", Offset = "0x8262650", VA = "0x188263250", Slot = "39")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x8265BB0", Offset = "0x8264FB0", VA = "0x188265BB0", Slot = "40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public Vector3 ANICHLGAPOL
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x8266A30", Offset = "0x8265E30", VA = "0x188266A30", Slot = "41")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x8261BD0", Offset = "0x8260FD0", VA = "0x188261BD0", Slot = "42")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public Vector3 NIMGIDAKOEF
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x8265400", Offset = "0x8264800", VA = "0x188265400", Slot = "43")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x8262300", Offset = "0x8261700", VA = "0x188262300", Slot = "44")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public Vector3 FNIBKHAODCL
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x8267150", Offset = "0x8266550", VA = "0x188267150", Slot = "45")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x8261AF0", Offset = "0x8260EF0", VA = "0x188261AF0", Slot = "46")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public Vector3 CCENGJCDCIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x82639B0", Offset = "0x8262DB0", VA = "0x1882639B0", Slot = "47")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x8261F90", Offset = "0x8261390", VA = "0x188261F90", Slot = "48")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public bool NBPLILMEDJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x8264E70", Offset = "0x8264270", VA = "0x188264E70", Slot = "49")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public bool HHEFAEPGCEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x8264820", Offset = "0x8263C20", VA = "0x188264820", Slot = "50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public bool DMHOGJNEKLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x8265980", Offset = "0x8264D80", VA = "0x188265980", Slot = "51")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public bool OINDCDNLCJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x8265CF0", Offset = "0x82650F0", VA = "0x188265CF0", Slot = "52")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public Vector3 HJDIAKGGDKO
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x8263D20", Offset = "0x8263120", VA = "0x188263D20", Slot = "53")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public Vector3 FDIMBJIKAKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x82621D0", Offset = "0x82615D0", VA = "0x1882621D0", Slot = "54")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public Vector3 FDDCDPJLIHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x8266190", Offset = "0x8265590", VA = "0x188266190", Slot = "55")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x8262B30", Offset = "0x8261F30", VA = "0x188262B30", Slot = "56")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public Vector3 GLPJNAEIHNP
	{
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x8266CC0", Offset = "0x82660C0", VA = "0x188266CC0", Slot = "57")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public float HBCFNHKMNPO
	{
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x82660E0", Offset = "0x82654E0", VA = "0x1882660E0", Slot = "58")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public float DNOMNDNMNPP
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x82648F0", Offset = "0x8263CF0", VA = "0x1882648F0", Slot = "59")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x8265EF0", Offset = "0x82652F0", VA = "0x188265EF0", Slot = "60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public Vector3 FDIHCFCMBDM
	{
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x8265C10", Offset = "0x8265010", VA = "0x188265C10", Slot = "61")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public Quaternion HFGLICCCKGF
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x8264EC0", Offset = "0x82642C0", VA = "0x188264EC0", Slot = "62")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public float KMAADDJCFLL
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x82676A0", Offset = "0x8266AA0", VA = "0x1882676A0", Slot = "64")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x8261A90", Offset = "0x8260E90", VA = "0x188261A90", Slot = "65")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public float ELIFMPDAEKP
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x82622B0", Offset = "0x82616B0", VA = "0x1882622B0", Slot = "66")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x8266B50", Offset = "0x8265F50", VA = "0x188266B50", Slot = "67")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public bool AOEDEHHIACP
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x82640C0", Offset = "0x82634C0", VA = "0x1882640C0", Slot = "68")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x8261E50", Offset = "0x8261250", VA = "0x188261E50", Slot = "69")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public OJCAHADJONK GADINEIPPPC
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x8265770", Offset = "0x8264B70", VA = "0x188265770", Slot = "70")]
		get
		{
			return default(OJCAHADJONK);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x8266130", Offset = "0x8265530", VA = "0x188266130", Slot = "71")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	public bool JINBBHINGPI
	{
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x8263C20", Offset = "0x8263020", VA = "0x188263C20", Slot = "72")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public Transform PKKOLONGCCG
	{
		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0xBE6830", Offset = "0xBE5C30", VA = "0x180BE6830", Slot = "73")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public Vector3 NGAMLDMOODD
	{
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x8263830", Offset = "0x8262C30", VA = "0x188263830", Slot = "74")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x8262920", Offset = "0x8261D20", VA = "0x188262920", Slot = "75")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public float BGKKIMPHKEN
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x8263240", Offset = "0x8262640", VA = "0x188263240", Slot = "76")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x8263500", Offset = "0x8262900", VA = "0x188263500", Slot = "77")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	public float HNMOFIKHMHL
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x8261D10", Offset = "0x8261110", VA = "0x188261D10", Slot = "78")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x8266370", Offset = "0x8265770", VA = "0x188266370", Slot = "79")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public Quaternion CGHLEMDADNJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x8267B50", Offset = "0x8266F50", VA = "0x188267B50", Slot = "80")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x82620F0", Offset = "0x82614F0", VA = "0x1882620F0", Slot = "81")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public Vector3 BDNGLNKLDEH
	{
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x82634C0", Offset = "0x82628C0", VA = "0x1882634C0", Slot = "82")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x8266B10", Offset = "0x8265F10", VA = "0x188266B10", Slot = "83")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public Quaternion KJKLIEAGBDO
	{
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x82672F0", Offset = "0x82666F0", VA = "0x1882672F0", Slot = "84")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x8264110", Offset = "0x8263510", VA = "0x188264110", Slot = "85")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	public RigidbodyConstraints PNAJJJHMEJC
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x8264070", Offset = "0x8263470", VA = "0x188264070", Slot = "86")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x82650F0", Offset = "0x82644F0", VA = "0x1882650F0", Slot = "87")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public bool GLHMNBANGDL
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x8262F00", Offset = "0x8262300", VA = "0x188262F00", Slot = "88")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x8264570", Offset = "0x8263970", VA = "0x188264570", Slot = "89")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public CollisionDetectionMode HKGNPADLCEP
	{
		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x8262DA0", Offset = "0x82621A0", VA = "0x188262DA0", Slot = "90")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x8263680", Offset = "0x8262A80", VA = "0x188263680", Slot = "91")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public bool INIJMNNNIEK
	{
		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x8265260", Offset = "0x8264660", VA = "0x188265260", Slot = "141")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public bool LNPODHPPPLB
	{
		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x82623E0", Offset = "0x82617E0", VA = "0x1882623E0", Slot = "92")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event HKGADDNGDGE FCONDJGCOBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x8265090", Offset = "0x8264490", VA = "0x188265090", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x8263BC0", Offset = "0x8262FC0", VA = "0x188263BC0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	public event HKGADDNGDGE KPEEKMGJIGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x8262A80", Offset = "0x8261E80", VA = "0x188262A80", Slot = "6")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x8262E50", Offset = "0x8262250", VA = "0x188262E50", Slot = "7")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000019")]
	public event OACFBICGIID IANGJMELBFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x8263B60", Offset = "0x8262F60", VA = "0x188263B60", Slot = "18")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x8267230", Offset = "0x8266630", VA = "0x188267230", Slot = "19")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	public event HKGADDNGDGE PLDPKJPPFGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x8265030", Offset = "0x8264430", VA = "0x188265030", Slot = "8")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x8262560", Offset = "0x8261960", VA = "0x188262560", Slot = "9")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	public event HKGADDNGDGE JIGPGNBHBAB
	{
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x8261CB0", Offset = "0x82610B0", VA = "0x188261CB0", Slot = "14")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x8265200", Offset = "0x8264600", VA = "0x188265200", Slot = "15")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001C")]
	public event HKGADDNGDGE DFBGBPDOIJE
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x82658C0", Offset = "0x8264CC0", VA = "0x1882658C0", Slot = "16")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x82653A0", Offset = "0x82647A0", VA = "0x1882653A0", Slot = "17")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001D")]
	public event Action<BAJKLLBGNIN, BAJKLLBGNIN> HOGOLDMCGIP
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x82668A0", Offset = "0x8265CA0", VA = "0x1882668A0", Slot = "20")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x8267290", Offset = "0x8266690", VA = "0x188267290", Slot = "21")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001E")]
	public event HKGADDNGDGE BFNHICKBAHI
	{
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x8264510", Offset = "0x8263910", VA = "0x188264510", Slot = "12")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x8263C70", Offset = "0x8263070", VA = "0x188263C70", Slot = "13")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001F")]
	public event HKGADDNGDGE ONHAHNFKGGI
	{
		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x8264940", Offset = "0x8263D40", VA = "0x188264940", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x82649F0", Offset = "0x8263DF0", VA = "0x1882649F0", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x8267C30", Offset = "0x8267030", VA = "0x188267C30")]
	public JDPJNFAEJIG(GameObject GMFIIANHHCH, RigidbodyEx KMGNJNAMCOO, BNNCIAIELHF BIGODBDFGBM, [In] ADADNNBAMPN AOFGGGKINCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x8267810", Offset = "0x8266C10", VA = "0x188267810", Slot = "139")]
	protected virtual void PLPBPJKKLDG(BNNCIAIELHF BIGODBDFGBM, ADADNNBAMPN AOFGGGKINCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x82633C0", Offset = "0x82627C0", VA = "0x1882633C0", Slot = "140")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x8264690", Offset = "0x8263A90", VA = "0x188264690", Slot = "93")]
	public void GNGOBIJMNKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x8263100", Offset = "0x8262500", VA = "0x188263100", Slot = "94")]
	public void DDJAFNOECHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x82677B0", Offset = "0x8266BB0", VA = "0x1882677B0", Slot = "95")]
	public void PLMAFFHIHCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x82636E0", Offset = "0x8262AE0", VA = "0x1882636E0", Slot = "96")]
	public void EKOHNNFCLEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x8264BF0", Offset = "0x8263FF0", VA = "0x188264BF0")]
	private void IBCEDLBGDLN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x8262070", Offset = "0x8261470", VA = "0x188262070")]
	private void BEAJICFPGHK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x8267750", Offset = "0x8266B50", VA = "0x188267750")]
	private void PLCGOJGJFDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x8263FF0", Offset = "0x82633F0", VA = "0x188263FF0", Slot = "30")]
	public GICFIFJOJFH FOGFABNHEBG(int COPLIEINKOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x8263350", Offset = "0x8262750", VA = "0x188263350", Slot = "98")]
	public void DNHIHCOJECG(GICFIFJOJFH OOEMJLHLIHJ, bool LPODAIKDKIP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x8265D90", Offset = "0x8265190", VA = "0x188265D90", Slot = "99")]
	public void LKKNDICBICA(object PAHPIGHLKFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x8264140", Offset = "0x8263540", VA = "0x188264140", Slot = "100")]
	public void GBNIJJAFBFL(object PAHPIGHLKFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x8266270", Offset = "0x8265670", VA = "0x188266270", Slot = "101")]
	public Vector3 MNPAKKLLLPG(Vector3 AOBMGFHHGEN)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x8265DF0", Offset = "0x82651F0", VA = "0x188265DF0", Slot = "102")]
	public Vector3 LLIEJOIKFEB(Vector3 HHLKLFCBGLL)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x8265D40", Offset = "0x8265140", VA = "0x188265D40", Slot = "103")]
	public void LKFAACLOCGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x82645D0", Offset = "0x82639D0", VA = "0x1882645D0", Slot = "104")]
	public void GMBBGNAIGNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x8265B60", Offset = "0x8264F60", VA = "0x188265B60", Slot = "105")]
	public void LGDDICODLPH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x8263F00", Offset = "0x8263300", VA = "0x188263F00", Slot = "106")]
	public void FNKJCMLNOEK(Vector3 PIFIIAMNLNN, Vector3 JBJBDCBDBHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x8262CB0", Offset = "0x82620B0", VA = "0x188262CB0", Slot = "107")]
	public void CJFAGBJBHIK(Vector3 BKGONMDOKLB, Vector3 MMINKAKFLHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x8264AA0", Offset = "0x8263EA0", VA = "0x188264AA0", Slot = "108")]
	public void HLIKJFMNOKC(Vector3 AELCMMAJOPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x8261D90", Offset = "0x8261190", VA = "0x188261D90", Slot = "109")]
	public void AMHAKPNCFDH(ACECPJNBPEC JIEFFOKJFPC, Vector3 OCHOJDMGPFE, float DCPCCMFADCM, float KCNBDGLKJNH = 8f, float FAJHCHFJGPO = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x8266ED0", Offset = "0x82662D0", VA = "0x188266ED0", Slot = "110")]
	public void OGJEHMOPEFB(IICCECNKAHL OEKEAMNGPPI, Vector3 LGKODENCBAE, float EACAFMBIMBN = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x82629D0", Offset = "0x8261DD0", VA = "0x1882629D0", Slot = "111")]
	[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
	public void CDINKAONFNP(IICCECNKAHL OEKEAMNGPPI, Vector3 PNEDBEMJDJJ, float EMALLGBKLKM = 7f, float FODFJNNAENB = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x8265A60", Offset = "0x8264E60", VA = "0x188265A60", Slot = "112")]
	public Vector3 LFLGNCMPGPB(Vector3 OOEMJLHLIHJ)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x82657C0", Offset = "0x8264BC0", VA = "0x1882657C0", Slot = "113")]
	public Vector3 KJACJPEGLAE(Vector3 OOEMJLHLIHJ)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x82669E0", Offset = "0x8265DE0", VA = "0x1882669E0", Slot = "114")]
	public void NPMBLMCMJII()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x8261D20", Offset = "0x8261120", VA = "0x188261D20", Slot = "115")]
	public void AIPHBPAIJOI(GICFIFJOJFH MGECHFICKLL, object PAHPIGHLKFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x8266C00", Offset = "0x8266000", VA = "0x188266C00", Slot = "116")]
	public void OEBAPFILJMO(object PAHPIGHLKFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x8265690", Offset = "0x8264A90", VA = "0x188265690", Slot = "63")]
	public void KGCBONACHIJ((Quaternion rot, Vector3 moments) CADPOCIBAEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x82647D0", Offset = "0x8263BD0", VA = "0x1882647D0", Slot = "117")]
	public void GPBGPFKDBDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x8267B00", Offset = "0x8266F00", VA = "0x188267B00", Slot = "118")]
	public void PMFMAHKOJNJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x8266BB0", Offset = "0x8265FB0", VA = "0x188266BB0", Slot = "119")]
	public void ODFGKKENEFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x8266090", Offset = "0x8265490", VA = "0x188266090", Slot = "120")]
	public bool MCMHMADGEPP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x8262EB0", Offset = "0x82622B0", VA = "0x188262EB0", Slot = "97")]
	public void DAKDHECJMED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x8264B80", Offset = "0x8263F80", VA = "0x188264B80", Slot = "121")]
	public void HPCDKCEBBJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x8262DF0", Offset = "0x82621F0", VA = "0x188262DF0", Slot = "122")]
	public void CKGJKLBKKKG(object PAHPIGHLKFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x82676F0", Offset = "0x8266AF0", VA = "0x1882676F0", Slot = "123")]
	public void PKCBLKKEDBN(object PAHPIGHLKFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x8264880", Offset = "0x8263C80", VA = "0x188264880", Slot = "124")]
	public void HCBBCKMJEDI(object PAHPIGHLKFG, bool IJHBPMOJNME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x82641A0", Offset = "0x82635A0", VA = "0x1882641A0", Slot = "125")]
	public void GIFDAOLDPJC(Vector3 LGBGLNCCKJC, Quaternion NGBFEBOBFHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x8267020", Offset = "0x8266420", VA = "0x188267020", Slot = "126")]
	public void OJECMJIJICL(Vector3 LFFOIEKCJLE, Quaternion IFPAFJMCLFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x8265150", Offset = "0x8264550", VA = "0x188265150", Slot = "127")]
	public bool IHIDMFIGPGP(float BIPFCDNOGAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x82632F0", Offset = "0x82626F0", VA = "0x1882632F0", Slot = "128")]
	public void DMNOBLHAFFB(object PAHPIGHLKFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x82631E0", Offset = "0x82625E0", VA = "0x1882631E0", Slot = "129")]
	public void DIHEPFPOCCM(object PAHPIGHLKFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x82651A0", Offset = "0x82645A0", VA = "0x1882651A0", Slot = "130")]
	public void IJOGEMIEIEO(object PAHPIGHLKFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x8266030", Offset = "0x8265430", VA = "0x188266030", Slot = "131")]
	public void MAGFMILKOFI(object PAHPIGHLKFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x8266900", Offset = "0x8265D00", VA = "0x188266900", Slot = "132")]
	public void NIDHOAOHIMA(Vector3 IMJBLFBLNHJ, ForceMode IPMAPBMKNFL = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x8263570", Offset = "0x8262970", VA = "0x188263570", Slot = "133")]
	public void EHHALGMHHCB(Vector3 IMJBLFBLNHJ, Vector3 KBPOHLLNAIG, ForceMode IPMAPBMKNFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x8265F50", Offset = "0x8265350", VA = "0x188265F50", Slot = "134")]
	public void LOJBAAEOHAN(Vector3 HAJDLEHAPNN, ForceMode IPMAPBMKNFL = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x8261EB0", Offset = "0x82612B0", VA = "0x188261EB0", Slot = "135")]
	public void AONNKIKMNDI(Vector3 HAJDLEHAPNN, ForceMode IPMAPBMKNFL = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x8262C10", Offset = "0x8262010", VA = "0x188262C10", Slot = "136")]
	public bool CHAMOAHNAFL(Vector3 DJMLEJBBDGG, [Out] RaycastHit LAJGANGDPIC, float IJIIMBMEDNE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x8267380", Offset = "0x8266780", VA = "0x188267380", Slot = "137")]
	public void PFOGNJACKCN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x8267BF0", Offset = "0x8266FF0", VA = "0x188267BF0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x8263A90", Offset = "0x8262E90", VA = "0x188263A90")]
	private void EPCAAJNMJKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x8263DF0", Offset = "0x82631F0", VA = "0x188263DF0")]
	private void FMJCOJFBDDG(GICFIFJOJFH GEFLCBDBKHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x82673D0", Offset = "0x82667D0", VA = "0x1882673D0")]
	private void PGGPEILFOGA(GICFIFJOJFH GEFLCBDBKHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x8266F70", Offset = "0x8266370", VA = "0x188266F70")]
	private void OJBCMDMLNFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x8263700", Offset = "0x8262B00", VA = "0x188263700")]
	private void EMFOFKHGCBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x8262F50", Offset = "0x8262350", VA = "0x188262F50")]
	private void DCDEODKAGLI(GICFIFJOJFH DPPJOLMEMMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x8261640", Offset = "0x8260A40", VA = "0x188261640")]
	private void ABBBDEDONGK(GICFIFJOJFH GEFLCBDBKHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x82638E0", Offset = "0x8262CE0", VA = "0x1882638E0")]
	private void EOAOFNLOHPL(GICFIFJOJFH GEFLCBDBKHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x82654E0", Offset = "0x82648E0", VA = "0x1882654E0")]
	private void KBEFDCJBPKJ(GOICLPNEOHK GEFLCBDBKHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x8266450", Offset = "0x8265850", VA = "0x188266450", Slot = "142")]
	protected virtual void NGJEKBBOOLH(GOICLPNEOHK HPGKJPCLFAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x82625C0", Offset = "0x82619C0", VA = "0x1882625C0")]
	protected void CCHDMIPNMOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x8261710", Offset = "0x8260B10", VA = "0x188261710")]
	protected void ACOGAHACHLK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x8266DA0", Offset = "0x82661A0", VA = "0x188266DA0")]
	private void OFNDJCLBJNB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x82643A0", Offset = "0x82637A0", VA = "0x1882643A0")]
	private void GINGEHENIJP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal static class OAFANPAEPNE
{
	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x82716F0", Offset = "0x8270AF0", VA = "0x1882716F0")]
	public static GICFIFJOJFH PMECNIJJKNP(this GICFIFJOJFH HPGKJPCLFAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x8271590", Offset = "0x8270990", VA = "0x188271590")]
	public static bool HBPGPHAIKMF(this GICFIFJOJFH HPGKJPCLFAN, GICFIFJOJFH BAJGMJFJAMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x82714F0", Offset = "0x82708F0", VA = "0x1882714F0")]
	public static bool ALLHJHOKFIG(this GICFIFJOJFH HPGKJPCLFAN, GICFIFJOJFH FAOIHHNBFMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x8271630", Offset = "0x8270A30", VA = "0x188271630")]
	public static GOICLPNEOHK KGLLJKCMPBG(this GICFIFJOJFH GDOONENKGAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x8271680", Offset = "0x8270A80", VA = "0x188271680")]
	public static JDPJNFAEJIG NFEEEFBAPDJ(this GICFIFJOJFH GDOONENKGAE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class NJPGPEACMMA : DBCHOEAKDFA
{
	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x826DDD0", Offset = "0x826D1D0", VA = "0x18826DDD0", Slot = "19")]
	public GICFIFJOJFH IOMGDCADJCE(RigidbodyEx HPGKJPCLFAN, ADADNNBAMPN AOFGGGKINCN, BNNCIAIELHF BIGODBDFGBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x9CB240", Offset = "0x9CA640", VA = "0x1809CB240", Slot = "4")]
	public PAMIPDFOPBD FHFMPNBPPIK(GICFIFJOJFH GDOONENKGAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x9CB240", Offset = "0x9CA640", VA = "0x1809CB240", Slot = "5")]
	public JCPGEPDHKEO DCHIODDDEKO(GICFIFJOJFH GDOONENKGAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x9CB240", Offset = "0x9CA640", VA = "0x1809CB240", Slot = "6")]
	public EACHHLKHPFC EEJIKAKPCPC(GICFIFJOJFH GDOONENKGAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x9CB240", Offset = "0x9CA640", VA = "0x1809CB240", Slot = "7")]
	public JMFCOKPIFND EHHJDJNPHLK(GICFIFJOJFH GDOONENKGAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x9CB240", Offset = "0x9CA640", VA = "0x1809CB240", Slot = "8")]
	public HDGJLLMIFGG FHLNDNDMMLE(GICFIFJOJFH GDOONENKGAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x9CB240", Offset = "0x9CA640", VA = "0x1809CB240", Slot = "9")]
	public CHHHPFDIIAH KNMJKOOAKBJ(GICFIFJOJFH GDOONENKGAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x9CB240", Offset = "0x9CA640", VA = "0x1809CB240", Slot = "10")]
	public MKHHEKNABIG HIPIPPDMIKP(GICFIFJOJFH GDOONENKGAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x9CB240", Offset = "0x9CA640", VA = "0x1809CB240", Slot = "11")]
	public DBFNPAONDKN HDKIEEFLOFJ(GICFIFJOJFH GDOONENKGAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x9CB240", Offset = "0x9CA640", VA = "0x1809CB240", Slot = "12")]
	public DDJPOLGNLCC KCCNBDOBKCK(GICFIFJOJFH GDOONENKGAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x9CB240", Offset = "0x9CA640", VA = "0x1809CB240", Slot = "13")]
	public KOHILGOLKPK LJKFKCPANEA(GICFIFJOJFH GDOONENKGAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x9CB240", Offset = "0x9CA640", VA = "0x1809CB240")]
	public HCIMJBHHCBB AIECANMENOP(GICFIFJOJFH GDOONENKGAE, [In] ADADNNBAMPN AOFGGGKINCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x9CB240", Offset = "0x9CA640", VA = "0x1809CB240")]
	public DNLKHBAOIHE NJKDKIBBMGN(GICFIFJOJFH GDOONENKGAE, [In] ADADNNBAMPN AOFGGGKINCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x9CB240", Offset = "0x9CA640", VA = "0x1809CB240")]
	public HCBFIFNJKMF DDFOIFJMCLJ(GICFIFJOJFH GDOONENKGAE, [In] ADADNNBAMPN AOFGGGKINCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x9CB240", Offset = "0x9CA640", VA = "0x1809CB240")]
	public OGNAHMKFMMK DNFNJJIJDBG(GICFIFJOJFH GDOONENKGAE, [In] ADADNNBAMPN AOFGGGKINCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x9CB240", Offset = "0x9CA640", VA = "0x1809CB240")]
	public IEMDINAOHOM ANJLLNLKNPF(GICFIFJOJFH GDOONENKGAE, [In] ADADNNBAMPN AOFGGGKINCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
	public NJPGPEACMMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x9CB240", Offset = "0x9CA640", VA = "0x1809CB240", Slot = "14")]
	private HCIMJBHHCBB DKANJDJOHFJ(GICFIFJOJFH GDOONENKGAE, [In] ADADNNBAMPN AOFGGGKINCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x9CB240", Offset = "0x9CA640", VA = "0x1809CB240", Slot = "15")]
	private DNLKHBAOIHE FCINKDGHPJP(GICFIFJOJFH GDOONENKGAE, [In] ADADNNBAMPN AOFGGGKINCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x9CB240", Offset = "0x9CA640", VA = "0x1809CB240", Slot = "16")]
	private HCBFIFNJKMF NNAKEPBOMKL(GICFIFJOJFH GDOONENKGAE, [In] ADADNNBAMPN AOFGGGKINCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x9CB240", Offset = "0x9CA640", VA = "0x1809CB240", Slot = "17")]
	private OGNAHMKFMMK LADMPCINPNN(GICFIFJOJFH GDOONENKGAE, [In] ADADNNBAMPN AOFGGGKINCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x9CB240", Offset = "0x9CA640", VA = "0x1809CB240", Slot = "18")]
	private IEMDINAOHOM PONONMFKFMA(GICFIFJOJFH GDOONENKGAE, [In] ADADNNBAMPN AOFGGGKINCN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[RegisterService(typeof(DBCHOEAKDFA), new string[] { })]
public class IGHLDCPGCIF : DBCHOEAKDFA, JFNILPFMLLH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private readonly DBCHOEAKDFA DIIIEFNFMLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private readonly DBCHOEAKDFA HPOFNMPOFCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private LJOJAACLEFE JPOBLHNDMNE;

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	private DBCHOEAKDFA DJDENOJBJFF
	{
		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x8260B60", Offset = "0x825FF60", VA = "0x188260B60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x8260CA0", Offset = "0x82600A0", VA = "0x188260CA0", Slot = "20")]
	public void InitReferences(KKNBMHIKNAE GDLAIBAPFED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x82608E0", Offset = "0x825FCE0", VA = "0x1882608E0", Slot = "4")]
	public PAMIPDFOPBD FHFMPNBPPIK(GICFIFJOJFH GDOONENKGAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x82604F0", Offset = "0x825F8F0", VA = "0x1882604F0", Slot = "5")]
	public JCPGEPDHKEO DCHIODDDEKO(GICFIFJOJFH GDOONENKGAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x82606F0", Offset = "0x825FAF0", VA = "0x1882606F0", Slot = "6")]
	public EACHHLKHPFC EEJIKAKPCPC(GICFIFJOJFH GDOONENKGAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x8260790", Offset = "0x825FB90", VA = "0x188260790", Slot = "7")]
	public JMFCOKPIFND EHHJDJNPHLK(GICFIFJOJFH GDOONENKGAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x8260980", Offset = "0x825FD80", VA = "0x188260980", Slot = "8")]
	public HDGJLLMIFGG FHLNDNDMMLE(GICFIFJOJFH GDOONENKGAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x8260D90", Offset = "0x8260190", VA = "0x188260D90", Slot = "9")]
	public CHHHPFDIIAH KNMJKOOAKBJ(GICFIFJOJFH GDOONENKGAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x8260AC0", Offset = "0x825FEC0", VA = "0x188260AC0", Slot = "10")]
	public MKHHEKNABIG HIPIPPDMIKP(GICFIFJOJFH GDOONENKGAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x8260A20", Offset = "0x825FE20", VA = "0x188260A20", Slot = "11")]
	public DBFNPAONDKN HDKIEEFLOFJ(GICFIFJOJFH GDOONENKGAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x8260CF0", Offset = "0x82600F0", VA = "0x188260CF0", Slot = "12")]
	public DDJPOLGNLCC KCCNBDOBKCK(GICFIFJOJFH GDOONENKGAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x8260E30", Offset = "0x8260230", VA = "0x188260E30", Slot = "13")]
	public KOHILGOLKPK LJKFKCPANEA(GICFIFJOJFH GDOONENKGAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x8260390", Offset = "0x825F790", VA = "0x188260390")]
	public HCIMJBHHCBB AIECANMENOP(GICFIFJOJFH GDOONENKGAE, [In] ADADNNBAMPN AOFGGGKINCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x8260830", Offset = "0x825FC30", VA = "0x188260830")]
	public DNLKHBAOIHE NJKDKIBBMGN(GICFIFJOJFH GDOONENKGAE, [In] ADADNNBAMPN AOFGGGKINCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x8260590", Offset = "0x825F990", VA = "0x188260590")]
	public HCBFIFNJKMF DDFOIFJMCLJ(GICFIFJOJFH GDOONENKGAE, [In] ADADNNBAMPN AOFGGGKINCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x8260640", Offset = "0x825FA40", VA = "0x188260640")]
	public OGNAHMKFMMK DNFNJJIJDBG(GICFIFJOJFH GDOONENKGAE, [In] ADADNNBAMPN AOFGGGKINCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x8260440", Offset = "0x825F840", VA = "0x188260440")]
	public IEMDINAOHOM ANJLLNLKNPF(GICFIFJOJFH GDOONENKGAE, [In] ADADNNBAMPN AOFGGGKINCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x8260BC0", Offset = "0x825FFC0", VA = "0x188260BC0", Slot = "19")]
	public GICFIFJOJFH IOMGDCADJCE(RigidbodyEx HPGKJPCLFAN, ADADNNBAMPN AOFGGGKINCN, BNNCIAIELHF BIGODBDFGBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x8260ED0", Offset = "0x82602D0", VA = "0x188260ED0")]
	public IGHLDCPGCIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x8260390", Offset = "0x825F790", VA = "0x188260390", Slot = "14")]
	private HCIMJBHHCBB DKANJDJOHFJ(GICFIFJOJFH GDOONENKGAE, [In] ADADNNBAMPN AOFGGGKINCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x8260830", Offset = "0x825FC30", VA = "0x188260830", Slot = "15")]
	private DNLKHBAOIHE FCINKDGHPJP(GICFIFJOJFH GDOONENKGAE, [In] ADADNNBAMPN AOFGGGKINCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x8260590", Offset = "0x825F990", VA = "0x188260590", Slot = "16")]
	private HCBFIFNJKMF NNAKEPBOMKL(GICFIFJOJFH GDOONENKGAE, [In] ADADNNBAMPN AOFGGGKINCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x8260640", Offset = "0x825FA40", VA = "0x188260640", Slot = "17")]
	private OGNAHMKFMMK LADMPCINPNN(GICFIFJOJFH GDOONENKGAE, [In] ADADNNBAMPN AOFGGGKINCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x8260440", Offset = "0x825F840", VA = "0x188260440", Slot = "18")]
	private IEMDINAOHOM PONONMFKFMA(GICFIFJOJFH GDOONENKGAE, [In] ADADNNBAMPN AOFGGGKINCN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface JLDGGFEEKBF : PAMIPDFOPBD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IJGKMPINBMM(GICFIFJOJFH HPGKJPCLFAN);

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MIFIFLOINKK(GICFIFJOJFH HPGKJPCLFAN);

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DMENJGGCCGL(GICFIFJOJFH DPPJOLMEMMB);

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void INIPLGPCMFP(GICFIFJOJFH DPPJOLMEMMB);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface FDLHIOCHLGD : EACHHLKHPFC
{
	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	DAPKNDOMACJ<GICFIFJOJFH> JMIBLGKNFFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	GICFIFJOJFH ECJBLEANLAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface FICDNKFABIB : OGNAHMKFMMK
{
	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	(float, Vector3) ADEHNGFKAEA(Rigidbody GMGODIBJAFD);
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public interface OLIDMHLKNNI : DNLKHBAOIHE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	PhotonView HHHKIKPIAGI
	{
		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal sealed class AABOKLABACI : DDJPOLGNLCC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private readonly JDPJNFAEJIG HPGKJPCLFAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private CollisionDetectionMode LKBDMJHOMGO;

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	private Rigidbody AOPHMJNJAKE
	{
		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x825C160", Offset = "0x825B560", VA = "0x18825C160")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public CollisionDetectionMode HKGNPADLCEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x825BDA0", Offset = "0x825B1A0", VA = "0x18825BDA0", Slot = "4")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x825BEC0", Offset = "0x825B2C0", VA = "0x18825BEC0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x825C230", Offset = "0x825B630", VA = "0x18825C230")]
	public AABOKLABACI(GICFIFJOJFH HPGKJPCLFAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x825BF30", Offset = "0x825B330", VA = "0x18825BF30", Slot = "6")]
	public void GNGOBIJMNKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x825C1B0", Offset = "0x825B5B0", VA = "0x18825C1B0", Slot = "9")]
	public void ICPNPHDEPFL(Rigidbody DKBIBNDFCGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x825BEB0", Offset = "0x825B2B0", VA = "0x18825BEB0", Slot = "7")]
	public void DDHKONLMDKA(bool KDDPMILKDKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x825BC30", Offset = "0x825B030", VA = "0x18825BC30", Slot = "8")]
	public void BODMAKHENJM(bool KDDPMILKDKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x825BC40", Offset = "0x825B040", VA = "0x18825BC40", Slot = "10")]
	public bool CHAMOAHNAFL(Vector3 DJMLEJBBDGG, [Out] RaycastHit LAJGANGDPIC, float IJIIMBMEDNE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x825C040", Offset = "0x825B440", VA = "0x18825C040")]
	private void HCJOGILHBEO(bool KDDPMILKDKB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class IMECFOCIJHA : CHHHPFDIIAH, IDisposable, ADBBNFIBLNJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly JDPJNFAEJIG HPGKJPCLFAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private OJCAHADJONK OKBFLHGJFIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private APLIPBJIGME BLJCODAODOL;

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public OJCAHADJONK GADINEIPPPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x8261240", Offset = "0x8260640", VA = "0x188261240", Slot = "6")]
		get
		{
			return default(OJCAHADJONK);
		}
		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x8261380", Offset = "0x8260780", VA = "0x188261380", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	private Transform KLBMMAALKEE
	{
		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0xC83610", Offset = "0xC82A10", VA = "0x180C83610", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000020")]
	public event Action<BAJKLLBGNIN, BAJKLLBGNIN> HOGOLDMCGIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x8261450", Offset = "0x8260850", VA = "0x188261450", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x8261500", Offset = "0x8260900", VA = "0x188261500", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x82615B0", Offset = "0x82609B0", VA = "0x1882615B0")]
	public IMECFOCIJHA(GICFIFJOJFH HPGKJPCLFAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x8260FD0", Offset = "0x82603D0", VA = "0x188260FD0", Slot = "8")]
	public void GNGOBIJMNKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x8260F80", Offset = "0x8260380", VA = "0x188260F80", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x1135690", Offset = "0x1134A90", VA = "0x181135690", Slot = "11")]
	private void KCOGBLEMPIM(BAJKLLBGNIN BEBNGOBPDJN, BAJKLLBGNIN DLPLDDMBNPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230", Slot = "12")]
	private void LOEJLMGGGPH(bool CADKGLGHDBD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class HBNEINNHMHB : DBCHOEAKDFA
{
	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x825EDB0", Offset = "0x825E1B0", VA = "0x18825EDB0", Slot = "4")]
	public PAMIPDFOPBD FHFMPNBPPIK(GICFIFJOJFH GDOONENKGAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x825E690", Offset = "0x825DA90", VA = "0x18825E690", Slot = "5")]
	public JCPGEPDHKEO DCHIODDDEKO(GICFIFJOJFH GDOONENKGAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x825EA70", Offset = "0x825DE70", VA = "0x18825EA70", Slot = "6")]
	public EACHHLKHPFC EEJIKAKPCPC(GICFIFJOJFH GDOONENKGAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x825EBA0", Offset = "0x825DFA0", VA = "0x18825EBA0", Slot = "7")]
	public JMFCOKPIFND EHHJDJNPHLK(GICFIFJOJFH GDOONENKGAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x825EEA0", Offset = "0x825E2A0", VA = "0x18825EEA0", Slot = "8")]
	public HDGJLLMIFGG FHLNDNDMMLE(GICFIFJOJFH GDOONENKGAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x825F360", Offset = "0x825E760", VA = "0x18825F360", Slot = "9")]
	public CHHHPFDIIAH KNMJKOOAKBJ(GICFIFJOJFH GDOONENKGAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x825F030", Offset = "0x825E430", VA = "0x18825F030", Slot = "10")]
	public MKHHEKNABIG HIPIPPDMIKP(GICFIFJOJFH GDOONENKGAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x825EF70", Offset = "0x825E370", VA = "0x18825EF70", Slot = "11")]
	public DBFNPAONDKN HDKIEEFLOFJ(GICFIFJOJFH GDOONENKGAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x825F2A0", Offset = "0x825E6A0", VA = "0x18825F2A0", Slot = "12")]
	public DDJPOLGNLCC KCCNBDOBKCK(GICFIFJOJFH GDOONENKGAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x825F430", Offset = "0x825E830", VA = "0x18825F430", Slot = "13")]
	public KOHILGOLKPK LJKFKCPANEA(GICFIFJOJFH GDOONENKGAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x825E470", Offset = "0x825D870", VA = "0x18825E470")]
	public HCIMJBHHCBB AIECANMENOP(GICFIFJOJFH GDOONENKGAE, [In] ADADNNBAMPN AOFGGGKINCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x825EC20", Offset = "0x825E020", VA = "0x18825EC20")]
	public DNLKHBAOIHE NJKDKIBBMGN(GICFIFJOJFH GDOONENKGAE, [In] ADADNNBAMPN AOFGGGKINCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x825E7B0", Offset = "0x825DBB0", VA = "0x18825E7B0")]
	public HCBFIFNJKMF DDFOIFJMCLJ(GICFIFJOJFH GDOONENKGAE, [In] ADADNNBAMPN AOFGGGKINCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x825E8E0", Offset = "0x825DCE0", VA = "0x18825E8E0")]
	public OGNAHMKFMMK DNFNJJIJDBG(GICFIFJOJFH GDOONENKGAE, [In] ADADNNBAMPN AOFGGGKINCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x825E5B0", Offset = "0x825D9B0", VA = "0x18825E5B0")]
	public IEMDINAOHOM ANJLLNLKNPF(GICFIFJOJFH GDOONENKGAE, [In] ADADNNBAMPN AOFGGGKINCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x825F150", Offset = "0x825E550", VA = "0x18825F150", Slot = "19")]
	public GICFIFJOJFH IOMGDCADJCE(RigidbodyEx HPGKJPCLFAN, ADADNNBAMPN AOFGGGKINCN, BNNCIAIELHF BIGODBDFGBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
	public HBNEINNHMHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x825E470", Offset = "0x825D870", VA = "0x18825E470", Slot = "14")]
	private HCIMJBHHCBB DKANJDJOHFJ(GICFIFJOJFH GDOONENKGAE, [In] ADADNNBAMPN AOFGGGKINCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x825EC20", Offset = "0x825E020", VA = "0x18825EC20", Slot = "15")]
	private DNLKHBAOIHE FCINKDGHPJP(GICFIFJOJFH GDOONENKGAE, [In] ADADNNBAMPN AOFGGGKINCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x825E7B0", Offset = "0x825DBB0", VA = "0x18825E7B0", Slot = "16")]
	private HCBFIFNJKMF NNAKEPBOMKL(GICFIFJOJFH GDOONENKGAE, [In] ADADNNBAMPN AOFGGGKINCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x825E8E0", Offset = "0x825DCE0", VA = "0x18825E8E0", Slot = "17")]
	private OGNAHMKFMMK LADMPCINPNN(GICFIFJOJFH GDOONENKGAE, [In] ADADNNBAMPN AOFGGGKINCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x825E5B0", Offset = "0x825D9B0", VA = "0x18825E5B0", Slot = "18")]
	private IEMDINAOHOM PONONMFKFMA(GICFIFJOJFH GDOONENKGAE, [In] ADADNNBAMPN AOFGGGKINCN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
internal sealed class ONGDIIOFBKJ : DBFNPAONDKN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly JDPJNFAEJIG HPGKJPCLFAN;

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	private Rigidbody AOPHMJNJAKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x825C160", Offset = "0x825B560", VA = "0x18825C160")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	private bool JINBBHINGPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x8271CF0", Offset = "0x82710F0", VA = "0x188271CF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	private bool MEPLBDGGGJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x825E240", Offset = "0x825D640", VA = "0x18825E240")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	private GICFIFJOJFH KCNKMLOKLAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x8271A10", Offset = "0x8270E10", VA = "0x188271A10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x825C230", Offset = "0x825B630", VA = "0x18825C230")]
	public ONGDIIOFBKJ(GICFIFJOJFH HPGKJPCLFAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x8272100", Offset = "0x8271500", VA = "0x188272100", Slot = "4")]
	public void NIDHOAOHIMA(Vector3 IMJBLFBLNHJ, ForceMode IPMAPBMKNFL = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x8271D40", Offset = "0x8271140", VA = "0x188271D40")]
	private void JDFDENMMOAI(Vector3 IMJBLFBLNHJ, ForceMode IPMAPBMKNFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0x8271A70", Offset = "0x8270E70", VA = "0x188271A70", Slot = "5")]
	public void EHHALGMHHCB(Vector3 IMJBLFBLNHJ, Vector3 KBPOHLLNAIG, ForceMode IPMAPBMKNFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x8271FA0", Offset = "0x82713A0", VA = "0x188271FA0", Slot = "6")]
	public void LOJBAAEOHAN(Vector3 HAJDLEHAPNN, ForceMode IPMAPBMKNFL = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0x8272260", Offset = "0x8271660", VA = "0x188272260")]
	private void PMHEDFCAJJD(Vector3 HAJDLEHAPNN, ForceMode IPMAPBMKNFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x82717B0", Offset = "0x8270BB0", VA = "0x1882717B0", Slot = "7")]
	public void AONNKIKMNDI(Vector3 HAJDLEHAPNN, ForceMode IPMAPBMKNFL = ForceMode.Force)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal sealed class HICNEENMNLB : KOHILGOLKPK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly JDPJNFAEJIG HPGKJPCLFAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private bool EMFDEDEPGAC;

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public bool AOEDEHHIACP
	{
		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0xA813E0", Offset = "0xA807E0", VA = "0x180A813E0", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x825F4F0", Offset = "0x825E8F0", VA = "0x18825F4F0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x825C230", Offset = "0x825B630", VA = "0x18825C230")]
	public HICNEENMNLB(GICFIFJOJFH HPGKJPCLFAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x825F600", Offset = "0x825EA00", VA = "0x18825F600", Slot = "6")]
	public void ICPNPHDEPFL(Rigidbody DKBIBNDFCGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x825F630", Offset = "0x825EA30", VA = "0x18825F630", Slot = "7")]
	public void NDPHAMPHODD(Rigidbody DKBIBNDFCGL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal sealed class JJFABBEKOGN : JLDGGFEEKBF, PAMIPDFOPBD, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private readonly GICFIFJOJFH HPGKJPCLFAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly List<GICFIFJOJFH> PLEDMDDDEEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private GICFIFJOJFH DGFFJNKGDJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private GICFIFJOJFH GEFLCBDBKHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private Transform ENDNKNMPHDK;

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	private Transform ACIFLJLGGLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x82682B0", Offset = "0x82676B0", VA = "0x1882682B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public GICFIFJOJFH KCNKMLOKLAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x9CD840", Offset = "0x9CCC40", VA = "0x1809CD840", Slot = "28")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x8269790", Offset = "0x8268B90", VA = "0x188269790", Slot = "29")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public GICFIFJOJFH IAKDDPPLCKG
	{
		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x9CD7D0", Offset = "0x9CCBD0", VA = "0x1809CD7D0", Slot = "27")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public IReadOnlyList<GICFIFJOJFH> EPNACLIAFPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x9CD860", Offset = "0x9CCC60", VA = "0x1809CD860", Slot = "26")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000021")]
	public event HKGADDNGDGE FCONDJGCOBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x82692C0", Offset = "0x82686C0", VA = "0x1882692C0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x8268F90", Offset = "0x8268390", VA = "0x188268F90", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000022")]
	public event HKGADDNGDGE KPEEKMGJIGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x8268310", Offset = "0x8267710", VA = "0x188268310", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x8268470", Offset = "0x8267870", VA = "0x188268470", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000023")]
	public event OACFBICGIID IANGJMELBFM
	{
		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x8268EF0", Offset = "0x82682F0", VA = "0x188268EF0", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x8269B60", Offset = "0x8268F60", VA = "0x188269B60", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000024")]
	public event Action EBDJHEIJEAB
	{
		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x8269D60", Offset = "0x8269160", VA = "0x188269D60", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x82696F0", Offset = "0x8268AF0", VA = "0x1882696F0", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000025")]
	public event Action CJGIDBPLCHF
	{
		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x8268510", Offset = "0x8267910", VA = "0x188268510", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x8268090", Offset = "0x8267490", VA = "0x188268090", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000026")]
	public event Action<GICFIFJOJFH> OGKIIPBDKCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x8269160", Offset = "0x8268560", VA = "0x188269160", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x8268E40", Offset = "0x8268240", VA = "0x188268E40", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000027")]
	public event Action<GICFIFJOJFH> PFOMNGJHGMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x8269CB0", Offset = "0x82690B0", VA = "0x188269CB0", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x8269210", Offset = "0x8268610", VA = "0x188269210", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000028")]
	public event Action PLGINMLHMHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x8269A20", Offset = "0x8268E20", VA = "0x188269A20", Slot = "22")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x8267FF0", Offset = "0x82673F0", VA = "0x188267FF0", Slot = "23")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000029")]
	public event Action<GICFIFJOJFH> NBNOKGKFLFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x82697A0", Offset = "0x8268BA0", VA = "0x1882697A0", Slot = "24")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x8269C00", Offset = "0x8269000", VA = "0x188269C00", Slot = "25")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x8269E00", Offset = "0x8269200", VA = "0x188269E00")]
	public JJFABBEKOGN(GICFIFJOJFH HPGKJPCLFAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x8268DA0", Offset = "0x82681A0", VA = "0x188268DA0", Slot = "31")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(RVA = "0x8268820", Offset = "0x8267C20", VA = "0x188268820", Slot = "30")]
	public void DNHIHCOJECG(GICFIFJOJFH EEKCDPNNHKN, bool LPODAIKDKIP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x82685B0", Offset = "0x82679B0", VA = "0x1882685B0", Slot = "6")]
	public void DMENJGGCCGL(GICFIFJOJFH DPPJOLMEMMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x8269470", Offset = "0x8268870", VA = "0x188269470", Slot = "7")]
	public void INIPLGPCMFP(GICFIFJOJFH DPPJOLMEMMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x8269360", Offset = "0x8268760", VA = "0x188269360", Slot = "4")]
	public void IJGKMPINBMM(GICFIFJOJFH HPGKJPCLFAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x8269850", Offset = "0x8268C50", VA = "0x188269850", Slot = "5")]
	public void MIFIFLOINKK(GICFIFJOJFH HPGKJPCLFAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x8269AC0", Offset = "0x8268EC0", VA = "0x188269AC0")]
	private void NOLLLILCFLG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x8268270", Offset = "0x8267670", VA = "0x188268270")]
	private void BKFJLNJBMFE(GICFIFJOJFH DPPJOLMEMMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x8268130", Offset = "0x8267530", VA = "0x188268130")]
	private void BJAMNCMINMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x82698F0", Offset = "0x8268CF0", VA = "0x1882698F0")]
	private void MOCIDEKENHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x8269030", Offset = "0x8268430", VA = "0x188269030")]
	private void GLEODPBJMNO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x82683B0", Offset = "0x82677B0", VA = "0x1882683B0")]
	[CompilerGenerated]
	private object CNPNOCEFNNI()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal static class CIDHMOGMFKD
{
	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x825CA60", Offset = "0x825BE60", VA = "0x18825CA60")]
	public static JLDGGFEEKBF HODKANHODDN(this GICFIFJOJFH GDOONENKGAE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal sealed class DFKKMOPPMHJ : FDLHIOCHLGD, EACHHLKHPFC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private readonly JDPJNFAEJIG HPGKJPCLFAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private readonly DAPKNDOMACJ<GICFIFJOJFH> GFLBFMHDGHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private bool PLLNDDHBKKL;

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public DAPKNDOMACJ<GICFIFJOJFH> JMIBLGKNFFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x9C9200", Offset = "0x9C8600", VA = "0x1809C9200", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public Vector3 HJDIAKGGDKO
	{
		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x825D0E0", Offset = "0x825C4E0", VA = "0x18825D0E0", Slot = "6")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public Vector3 FDIMBJIKAKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x825CEC0", Offset = "0x825C2C0", VA = "0x18825CEC0", Slot = "7")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	private Vector3 FNIBKHAODCL
	{
		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x825D230", Offset = "0x825C630", VA = "0x18825D230")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public GICFIFJOJFH ECJBLEANLAI
	{
		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x825D110", Offset = "0x825C510", VA = "0x18825D110", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x825D6B0", Offset = "0x825CAB0", VA = "0x18825D6B0")]
	public DFKKMOPPMHJ(GICFIFJOJFH HPGKJPCLFAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x825D1C0", Offset = "0x825C5C0", VA = "0x18825D1C0", Slot = "8")]
	public void JCOIPKGHBPI(GICFIFJOJFH GEFLCBDBKHP, object PAHPIGHLKFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x825D080", Offset = "0x825C480", VA = "0x18825D080", Slot = "9")]
	public void EACFAJMOAEG(object PAHPIGHLKFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x825CB20", Offset = "0x825BF20", VA = "0x18825CB20")]
	private Vector3 AIMMBPGMMBH()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x825D320", Offset = "0x825C720", VA = "0x18825D320")]
	private void PGCBMBAEOIO(GICFIFJOJFH NKKOCGLCGLP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal static class GKPJANLKCDC
{
	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x825E3B0", Offset = "0x825D7B0", VA = "0x18825E3B0")]
	public static FDLHIOCHLGD BEFJLCEIMIG(this GICFIFJOJFH GDOONENKGAE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal sealed class MFIHAGEHJGM : FICDNKFABIB, OGNAHMKFMMK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private readonly JDPJNFAEJIG HPGKJPCLFAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private readonly OverridableVector3 KKHJCDFCJKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly OverridableVector3 MDNKHNCENEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private float NAFPEBPFOHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private float JPAJIDFLKFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private Vector3 FFIEBDNIHIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private Vector3? HPJNAEPAFBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private Quaternion? GPBCOCAGLFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private bool OLFCBCLGNPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x79")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private bool PGCDNOOACML;

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public Vector3 FDDCDPJLIHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x158D1A0", Offset = "0x158C5A0", VA = "0x18158D1A0", Slot = "7")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x826C630", Offset = "0x826BA30", VA = "0x18826C630", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public Vector3 GLPJNAEIHNP
	{
		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x826D610", Offset = "0x826CA10", VA = "0x18826D610", Slot = "9")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public float HBCFNHKMNPO
	{
		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0xCAA360", Offset = "0xCA9760", VA = "0x180CAA360", Slot = "10")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x826C520", Offset = "0x826B920", VA = "0x18826C520")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public float DNOMNDNMNPP
	{
		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0xBD1C50", Offset = "0xBD1050", VA = "0x180BD1C50", Slot = "11")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x826D1D0", Offset = "0x826C5D0", VA = "0x18826D1D0", Slot = "12")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public Vector3 FDIHCFCMBDM
	{
		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x826D040", Offset = "0x826C440", VA = "0x18826D040", Slot = "13")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public Quaternion HFGLICCCKGF
	{
		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x826CA20", Offset = "0x826BE20", VA = "0x18826CA20", Slot = "14")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	private Rigidbody AOPHMJNJAKE
	{
		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x826A8E0", Offset = "0x8269CE0", VA = "0x18826A8E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002A")]
	public event HKGADDNGDGE POBAPENBDHP
	{
		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x826CC80", Offset = "0x826C080", VA = "0x18826CC80", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x826C860", Offset = "0x826BC60", VA = "0x18826C860", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x826DC70", Offset = "0x826D070", VA = "0x18826DC70")]
	public MFIHAGEHJGM(GICFIFJOJFH HPGKJPCLFAN, [In] ADADNNBAMPN AOFGGGKINCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x826C900", Offset = "0x826BD00", VA = "0x18826C900", Slot = "17")]
	public void GPBGPFKDBDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x826DB90", Offset = "0x826CF90", VA = "0x18826DB90", Slot = "16")]
	public void PMFMAHKOJNJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x826CBA0", Offset = "0x826BFA0", VA = "0x18826CBA0", Slot = "19")]
	public void ICPNPHDEPFL(Rigidbody DKBIBNDFCGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x826D280", Offset = "0x826C680", VA = "0x18826D280", Slot = "20")]
	public void NDPHAMPHODD(Rigidbody DKBIBNDFCGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x826D460", Offset = "0x826C860", VA = "0x18826D460", Slot = "18")]
	public void ODFGKKENEFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x826D700", Offset = "0x826CB00", VA = "0x18826D700", Slot = "21")]
	public void PFOGNJACKCN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x826C630", Offset = "0x826BA30", VA = "0x18826C630")]
	private void PHNLFNHBBIB(Vector3 OOEMJLHLIHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x826CF50", Offset = "0x826C350", VA = "0x18826CF50")]
	[Obsolete("This method is dangerous - the unity rigidbody is updated in a deferred manner and this world position may be stale")]
	private Vector3 LHCMFKMLNBO()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x826C520", Offset = "0x826B920", VA = "0x18826C520")]
	private void LMFJGHMGJFL(float OOEMJLHLIHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x826D1D0", Offset = "0x826C5D0", VA = "0x18826D1D0")]
	private void PPLDHHCPPNM(float OOEMJLHLIHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x826C380", Offset = "0x826B780", VA = "0x18826C380")]
	private Vector3 AMCMEALILHF()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x826CD20", Offset = "0x826C120", VA = "0x18826CD20", Slot = "15")]
	public void KGCBONACHIJ((Quaternion rot, Vector3 moments) CADPOCIBAEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x826C6E0", Offset = "0x826BAE0", VA = "0x18826C6E0")]
	private Quaternion DOLLFHKPJHF()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x826C2B0", Offset = "0x826B6B0", VA = "0x18826C2B0")]
	public void ADEHNGFKAEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x826B500", Offset = "0x826A900", VA = "0x18826B500", Slot = "4")]
	public (float, Vector3) ADEHNGFKAEA(Rigidbody GMGODIBJAFD)
	{
		return default((float, Vector3));
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal static class DIJFMFFBJOM
{
	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x825D7B0", Offset = "0x825CBB0", VA = "0x18825D7B0")]
	public static FICDNKFABIB BJJLHELLCKG(this GICFIFJOJFH GDOONENKGAE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal sealed class AFHKLOKDOKM : HCBFIFNJKMF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private readonly JDPJNFAEJIG HPGKJPCLFAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly MPPAGCOCNOM PLLEEADMDNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly GPDLPHADFJO HAEPBLJIHNG;

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public bool NAEJNNBNLNO
	{
		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x172AFC0", Offset = "0x172A3C0", VA = "0x18172AFC0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public GPDLPHADFJO EPFLNBHKDOF
	{
		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0xBC4000", Offset = "0xBC3400", VA = "0x180BC4000", Slot = "11")]
		get
		{
			return default(GPDLPHADFJO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x825C8F0", Offset = "0x825BCF0", VA = "0x18825C8F0")]
	public AFHKLOKDOKM(GICFIFJOJFH HPGKJPCLFAN, [In] ADADNNBAMPN AOFGGGKINCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x825C3C0", Offset = "0x825B7C0", VA = "0x18825C3C0", Slot = "4")]
	public void GNGOBIJMNKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x825C320", Offset = "0x825B720", VA = "0x18825C320")]
	private bool GLAOENKOHKA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x825C2C0", Offset = "0x825B6C0", VA = "0x18825C2C0", Slot = "5")]
	public void CAKNFHDNAPC(object PAHPIGHLKFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x825C2F0", Offset = "0x825B6F0", VA = "0x18825C2F0", Slot = "6")]
	public void EADFFCPFEIG(object PAHPIGHLKFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x825C510", Offset = "0x825B910", VA = "0x18825C510", Slot = "9")]
	public void LHFOCCLPOCB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x825C650", Offset = "0x825BA50", VA = "0x18825C650")]
	private void MGBKGMFPJMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0x825C770", Offset = "0x825BB70", VA = "0x18825C770")]
	private void NCGJFGHJMAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x825C4D0", Offset = "0x825B8D0", VA = "0x18825C4D0", Slot = "8")]
	public void LFMLFBJGKCL(GICFIFJOJFH HPGKJPCLFAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x825C490", Offset = "0x825B890", VA = "0x18825C490", Slot = "7")]
	public void ILHKFHINLAA(GICFIFJOJFH HPGKJPCLFAN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal sealed class MCLOKCNNJBN : MKHHEKNABIG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private readonly JDPJNFAEJIG HPGKJPCLFAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private readonly MPPAGCOCNOM JODNGNKADJK;

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public bool JINBBHINGPI
	{
		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x826B010", Offset = "0x826A410", VA = "0x18826B010", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002B")]
	public event HKGADDNGDGE BFNHICKBAHI
	{
		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x826B160", Offset = "0x826A560", VA = "0x18826B160", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x826B0C0", Offset = "0x826A4C0", VA = "0x18826B0C0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x826B410", Offset = "0x826A810", VA = "0x18826B410")]
	public MCLOKCNNJBN(GICFIFJOJFH HPGKJPCLFAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x826B000", Offset = "0x826A400", VA = "0x18826B000", Slot = "7")]
	public void CKGJKLBKKKG(object PAHPIGHLKFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x826B400", Offset = "0x826A800", VA = "0x18826B400", Slot = "8")]
	public void PKCBLKKEDBN(object PAHPIGHLKFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x826B200", Offset = "0x826A600", VA = "0x18826B200", Slot = "9")]
	public void HCBBCKMJEDI(object PAHPIGHLKFG, bool IJHBPMOJNME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x826B3C0", Offset = "0x826A7C0", VA = "0x18826B3C0", Slot = "12")]
	public void NIDLHDHNMDL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x826B310", Offset = "0x826A710", VA = "0x18826B310", Slot = "10")]
	public void ICPNPHDEPFL(Rigidbody HHPFGDJAMCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x826B390", Offset = "0x826A790", VA = "0x18826B390", Slot = "11")]
	public void NDPHAMPHODD(Rigidbody DKBIBNDFCGL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal sealed class IFJBEEMFHNG : OLIDMHLKNNI, DNLKHBAOIHE, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly JDPJNFAEJIG HPGKJPCLFAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private PhotonView MLJHONPGHOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private bool BNDIPEBCIEA;

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public PhotonView HHHKIKPIAGI
	{
		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x9CFD20", Offset = "0x9CF120", VA = "0x1809CFD20", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public bool PPPIDLACBDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x825FA00", Offset = "0x825EE00", VA = "0x18825FA00", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public bool GODGINKKHJC
	{
		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0xD74840", Offset = "0xD73C40", VA = "0x180D74840", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002C")]
	public event HKGADDNGDGE PLDPKJPPFGE
	{
		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x825FDC0", Offset = "0x825F1C0", VA = "0x18825FDC0", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x825F810", Offset = "0x825EC10", VA = "0x18825F810", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x8260240", Offset = "0x825F640", VA = "0x188260240")]
	public IFJBEEMFHNG(GICFIFJOJFH HPGKJPCLFAN, [In] ADADNNBAMPN AOFGGGKINCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x825FC90", Offset = "0x825F090", VA = "0x18825FC90", Slot = "9")]
	public void GNGOBIJMNKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x825FA20", Offset = "0x825EE20", VA = "0x18825FA20", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x825F6A0", Offset = "0x825EAA0", VA = "0x18825F6A0", Slot = "10")]
	public void ABBBDEDONGK(GICFIFJOJFH GEFLCBDBKHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x825FB20", Offset = "0x825EF20", VA = "0x18825FB20", Slot = "11")]
	public void EOAOFNLOHPL(GICFIFJOJFH GEFLCBDBKHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x82600D0", Offset = "0x825F4D0", VA = "0x1882600D0")]
	private void MJCCHOPIJFK(PhotonView IMBAAGBELCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x825F8B0", Offset = "0x825ECB0", VA = "0x18825F8B0")]
	private void CNNLHDEEFIH(GOICLPNEOHK LEFAOGFOFNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x825FE60", Offset = "0x825F260", VA = "0x18825FE60")]
	private void IMIAGCGLMDA(PhotonView IGGAMFJCBMO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
internal static class MBJLLAHDOMO
{
	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x826AF40", Offset = "0x826A340", VA = "0x18826AF40")]
	public static OLIDMHLKNNI NDILDNMMIOE(this GICFIFJOJFH GDOONENKGAE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
internal sealed class KCLIDBBHMPK : IEMDINAOHOM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly JDPJNFAEJIG HPGKJPCLFAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private RigidbodyConstraints DPGBGNIJCOG;

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public bool GLHMNBANGDL
	{
		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0xA28FD0", Offset = "0xA283D0", VA = "0x180A28FD0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0xCE7D10", Offset = "0xCE7110", VA = "0x180CE7D10", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public bool EOFFNKDIBDE
	{
		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0xCE79C0", Offset = "0xCE6DC0", VA = "0x180CE79C0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0xCE7D00", Offset = "0xCE7100", VA = "0x180CE7D00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public RigidbodyConstraints PNAJJJHMEJC
	{
		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x9D5BF0", Offset = "0x9D4FF0", VA = "0x1809D5BF0", Slot = "7")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x8269EF0", Offset = "0x82692F0", VA = "0x188269EF0", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x826A050", Offset = "0x8269450", VA = "0x18826A050")]
	public KCLIDBBHMPK(GICFIFJOJFH HPGKJPCLFAN, [In] ADADNNBAMPN AOFGGGKINCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x8269EC0", Offset = "0x82692C0", VA = "0x188269EC0", Slot = "9")]
	public void ICPNPHDEPFL(Rigidbody DKBIBNDFCGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x826A020", Offset = "0x8269420", VA = "0x18826A020", Slot = "10")]
	public void NDPHAMPHODD(Rigidbody DKBIBNDFCGL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal sealed class JENCHCMKCCK : JMFCOKPIFND
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private readonly GICFIFJOJFH HPGKJPCLFAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private float HEKBEHMEPEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private float IHAJIBMNICB;

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public float KMAADDJCFLL
	{
		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0xEA4540", Offset = "0xEA3940", VA = "0x180EA4540", Slot = "4")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x8267D20", Offset = "0x8267120", VA = "0x188267D20", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public float ELIFMPDAEKP
	{
		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0xCF3E70", Offset = "0xCF3270", VA = "0x180CF3E70", Slot = "6")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x8267EE0", Offset = "0x82672E0", VA = "0x188267EE0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x8267FB0", Offset = "0x82673B0", VA = "0x188267FB0")]
	public JENCHCMKCCK(GICFIFJOJFH HPGKJPCLFAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x8267DF0", Offset = "0x82671F0", VA = "0x188267DF0", Slot = "8")]
	public void ICPNPHDEPFL(Rigidbody DKBIBNDFCGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x8267E40", Offset = "0x8267240", VA = "0x188267E40", Slot = "9")]
	public void NDPHAMPHODD(Rigidbody DKBIBNDFCGL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
internal sealed class LEBGLPMLBDM : HDGJLLMIFGG
{
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private static readonly LMKAPNBAFDO LBCHGCGAAIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private readonly JDPJNFAEJIG HPGKJPCLFAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private bool GAPHELPHLGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private bool OMJILELDFAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private int HPCAINGOKFI;

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	private Rigidbody AOPHMJNJAKE
	{
		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x826A8E0", Offset = "0x8269CE0", VA = "0x18826A8E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	private bool INIJMNNNIEK
	{
		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x826A930", Offset = "0x8269D30", VA = "0x18826A930")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	private GICFIFJOJFH KCNKMLOKLAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x826A160", Offset = "0x8269560", VA = "0x18826A160")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	private bool MEPLBDGGGJF
	{
		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x826ABF0", Offset = "0x8269FF0", VA = "0x18826ABF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002D")]
	public event HKGADDNGDGE DFBGBPDOIJE
	{
		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x826AA00", Offset = "0x8269E00", VA = "0x18826AA00", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x826A950", Offset = "0x8269D50", VA = "0x18826A950", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x826ADA0", Offset = "0x826A1A0", VA = "0x18826ADA0")]
	public LEBGLPMLBDM(GICFIFJOJFH HPGKJPCLFAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x826A4F0", Offset = "0x82698F0", VA = "0x18826A4F0", Slot = "6")]
	public void GNGOBIJMNKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x826A9F0", Offset = "0x8269DF0", VA = "0x18826A9F0", Slot = "8")]
	public void KIEFKPCKNHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x826AAA0", Offset = "0x8269EA0", VA = "0x18826AAA0", Slot = "7")]
	public bool MCMHMADGEPP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x826A1C0", Offset = "0x82695C0", VA = "0x18826A1C0", Slot = "9")]
	public void DAKDHECJMED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x826A710", Offset = "0x8269B10", VA = "0x18826A710", Slot = "13")]
	public void HPCDKCEBBJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x826A7B0", Offset = "0x8269BB0", VA = "0x18826A7B0", Slot = "12")]
	public void IBCEDLBGDLN(bool NIIFBEGBKJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x826A0F0", Offset = "0x82694F0", VA = "0x18826A0F0", Slot = "10")]
	public bool ABNDODAJOFC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x826AC50", Offset = "0x826A050", VA = "0x18826AC50", Slot = "11")]
	public bool PLCGOJGJFDG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x826A260", Offset = "0x8269660", VA = "0x18826A260")]
	private bool GMNOPANHILC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x826A580", Offset = "0x8269980", VA = "0x18826A580")]
	private void HBBFDLANAMD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal sealed class FIGOFHCGMFB : HCIMJBHHCBB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private readonly JDPJNFAEJIG HPGKJPCLFAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly MPPAGCOCNOM DGPJOMPPGNL;

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public Rigidbody AOPHMJNJAKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0x9CFD20", Offset = "0x9CF120", VA = "0x1809CFD20", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0x9CCC50", Offset = "0x9CC050", VA = "0x1809CCC50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	private bool MEPLBDGGGJF
	{
		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0x825E240", Offset = "0x825D640", VA = "0x18825E240")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public bool KLGPNIKIJCF
	{
		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x172AFC0", Offset = "0x172A3C0", VA = "0x18172AFC0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x825E2A0", Offset = "0x825D6A0", VA = "0x18825E2A0")]
	public FIGOFHCGMFB(GICFIFJOJFH HPGKJPCLFAN, [In] ADADNNBAMPN AOFGGGKINCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x825DF50", Offset = "0x825D350", VA = "0x18825DF50", Slot = "5")]
	public void GNGOBIJMNKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x825DFF0", Offset = "0x825D3F0", VA = "0x18825DFF0", Slot = "7")]
	public void IJOGEMIEIEO(object PAHPIGHLKFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x825E020", Offset = "0x825D420", VA = "0x18825E020", Slot = "8")]
	public void MAGFMILKOFI(object PAHPIGHLKFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x825DAA0", Offset = "0x825CEA0", VA = "0x18825DAA0", Slot = "9")]
	public void DKBIHBCABGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x825E050", Offset = "0x825D450", VA = "0x18825E050", Slot = "10")]
	public void NGNOOHIFDIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x825DDD0", Offset = "0x825D1D0", VA = "0x18825DDD0", Slot = "11")]
	public void GAABFLFBBKG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
internal sealed class NMMGJHJIBLD : JCPGEPDHKEO, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private readonly JDPJNFAEJIG HPGKJPCLFAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly MPPAGCOCNOM MILMAFAENAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private float ANPEKBMOALB;

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public AIBIADFLBPK NMAHICPLDKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0x9C91B0", Offset = "0x9C85B0", VA = "0x1809C91B0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0x9D24A0", Offset = "0x9D18A0", VA = "0x1809D24A0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public DJGGIEMJFKA IIGGFPNAGBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0x9C9230", Offset = "0x9C8630", VA = "0x1809C9230", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0x9D24B0", Offset = "0x9D18B0", VA = "0x1809D24B0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public Vector3 FNIBKHAODCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x82712B0", Offset = "0x82706B0", VA = "0x1882712B0", Slot = "8")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x826DE70", Offset = "0x826D270", VA = "0x18826DE70", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public Vector3 ANICHLGAPOL
	{
		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x8270F00", Offset = "0x8270300", VA = "0x188270F00", Slot = "10")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x826DF30", Offset = "0x826D330", VA = "0x18826DF30", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public Vector3 CCENGJCDCIL
	{
		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x826F2B0", Offset = "0x826E6B0", VA = "0x18826F2B0", Slot = "12")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x826E5C0", Offset = "0x826D9C0", VA = "0x18826E5C0", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public Vector3 NIMGIDAKOEF
	{
		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x8270660", Offset = "0x826FA60", VA = "0x188270660", Slot = "14")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x826E680", Offset = "0x826DA80", VA = "0x18826E680", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public float IPPOJNBGJAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0xEACDC0", Offset = "0xEAC1C0", VA = "0x180EACDC0", Slot = "16")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x8270780", Offset = "0x826FB80", VA = "0x188270780", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public bool OINDCDNLCJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x206A770", Offset = "0x2069B70", VA = "0x18206A770", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	private DBFNPAONDKN JNEGCKLNMNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x7893200", Offset = "0x7892600", VA = "0x187893200")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	private bool INIJMNNNIEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0x8270640", Offset = "0x826FA40", VA = "0x188270640")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x8271400", Offset = "0x8270800", VA = "0x188271400")]
	public NMMGJHJIBLD(GICFIFJOJFH HPGKJPCLFAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x826FE30", Offset = "0x826F230", VA = "0x18826FE30", Slot = "19")]
	public void GNGOBIJMNKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x826EDC0", Offset = "0x826E1C0", VA = "0x18826EDC0", Slot = "36")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x8270080", Offset = "0x826F480", VA = "0x188270080", Slot = "28")]
	public void ICPNPHDEPFL(Rigidbody DKBIBNDFCGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x152BF30", Offset = "0x152B330", VA = "0x18152BF30", Slot = "20")]
	public void MCONLBHNHCA(object PAHPIGHLKFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x152B1B0", Offset = "0x152A5B0", VA = "0x18152B1B0", Slot = "30")]
	public void EHJGKDLOAGA(object PAHPIGHLKFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x8270B90", Offset = "0x826FF90", VA = "0x188270B90", Slot = "35")]
	public Vector3 MNPAKKLLLPG(Vector3 AOBMGFHHGEN)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x82709D0", Offset = "0x826FDD0", VA = "0x1882709D0", Slot = "34")]
	public Vector3 LLIEJOIKFEB(Vector3 HHLKLFCBGLL)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x826FE30", Offset = "0x826F230", VA = "0x18826FE30", Slot = "27")]
	public void LKFAACLOCGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x826FDD0", Offset = "0x826F1D0", VA = "0x18826FDD0", Slot = "25")]
	public void GMBBGNAIGNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x8270970", Offset = "0x826FD70", VA = "0x188270970", Slot = "24")]
	public void LGDDICODLPH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x826F5E0", Offset = "0x826E9E0", VA = "0x18826F5E0", Slot = "33")]
	public void FNKJCMLNOEK(Vector3 PIFIIAMNLNN, Vector3 JBJBDCBDBHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x826EBC0", Offset = "0x826DFC0", VA = "0x18826EBC0", Slot = "32")]
	public void CJFAGBJBHIK(Vector3 BKGONMDOKLB, Vector3 MMINKAKFLHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x826FEE0", Offset = "0x826F2E0", VA = "0x18826FEE0", Slot = "31")]
	public void HLIKJFMNOKC(Vector3 AELCMMAJOPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x826DF60", Offset = "0x826D360", VA = "0x18826DF60", Slot = "22")]
	public void AMHAKPNCFDH(ACECPJNBPEC JIEFFOKJFPC, Vector3 OCHOJDMGPFE, float DCPCCMFADCM, float KCNBDGLKJNH = 8f, float FAJHCHFJGPO = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x8271020", Offset = "0x8270420", VA = "0x188271020", Slot = "21")]
	public void OGJEHMOPEFB(IICCECNKAHL OEKEAMNGPPI, Vector3 LGKODENCBAE, float EACAFMBIMBN = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x826E6B0", Offset = "0x826DAB0", VA = "0x18826E6B0", Slot = "23")]
	[Obsolete("Deprecated. Still exists to support deprecated CV2 chips. Use ApplyAngularVelocityChange.")]
	public void CDINKAONFNP(IICCECNKAHL OEKEAMNGPPI, Vector3 PNEDBEMJDJJ, float EMALLGBKLKM = 7f, float FODFJNNAENB = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x1669210", Offset = "0x1668610", VA = "0x181669210")]
	private static void LOHDHEBHFLA(Vector3 GEIOPELMCBI, Vector3 KBGACFDBMJG, [Out] Vector3 MDDHKLNFDKN, [Out] Vector3 AMCNHBHOKFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x8270890", Offset = "0x826FC90", VA = "0x188270890", Slot = "29")]
	public Vector3 LFLGNCMPGPB(Vector3 GEIOPELMCBI)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x8270D70", Offset = "0x8270170", VA = "0x188270D70", Slot = "26")]
	public void NPMBLMCMJII()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x8270780", Offset = "0x826FB80", VA = "0x188270780")]
	private void JJINLKCDLAF(float OOEMJLHLIHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x826EC20", Offset = "0x826E020", VA = "0x18826EC20")]
	private void DHJHEBLDIBB(Vector3 LGKODENCBAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x826F410", Offset = "0x826E810", VA = "0x18826F410")]
	private Vector3 FFBCLGGDOJF()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x82701B0", Offset = "0x826F5B0", VA = "0x1882701B0")]
	private void IGPKFFEMNOF(Vector3 HHLKLFCBGLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x826EAA0", Offset = "0x826DEA0", VA = "0x18826EAA0")]
	private Vector3 CFEAFBNKCEG()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x826EE20", Offset = "0x826E220", VA = "0x18826EE20")]
	private void ELOLADGEGEJ(Vector3 OOEMJLHLIHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x826F820", Offset = "0x826EC20", VA = "0x18826F820")]
	private void GLLGEIFIKOK(Vector3 HHLKLFCBGLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x826F530", Offset = "0x826E930", VA = "0x18826F530")]
	private void FLJCPMFPKLM()
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
